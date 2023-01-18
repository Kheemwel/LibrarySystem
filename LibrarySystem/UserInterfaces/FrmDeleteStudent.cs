using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmDeleteStudent : Form
    {
        private readonly SqlConnection sqlConnection;
        private readonly UCStudents ucStudents;
        public FrmDeleteStudent(UCStudents uCStudents)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(SQLDatabaseUtils.StringConnection);
            sqlConnection.Open();
            ucStudents = uCStudents;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            AddUnderline(tbDeleteStudentID);
        }
        private void AddUnderline(TextBox tb)
        {
            tb.BorderStyle = BorderStyle.None;
            Panel underline = new Panel
            {
                Size = new Size(tb.Width, 1),
                Location = new Point(tb.Left, tb.Bottom + 2),
                BackColor = Color.Gray
            };
            tb.Parent.Controls.Add(underline);
        }

        private void FrmDeleteStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucStudents.LoadStudents();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDeleteStudentID.Text))
            {

                MessageBox.Show("Please enter a student ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbDeleteStudentID.Text, out int primaryKeyValue))
            {

                MessageBox.Show("The student ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectStudent = "SELECT studentFirstName, studentMiddleInitial, studentLastName FROM Students WHERE studentID = @primaryKeyValue";
            string studentName = "";
            using (SqlCommand command = new SqlCommand(selectStudent, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["studentFirstName"].ToString();
                        string middleInitial = reader["studentMiddleInitial"].ToString();
                        string lastName = reader["studentLastName"].ToString();
                        studentName = $"{firstName} {middleInitial} {lastName}";
                    }
                }
            }

            if (string.IsNullOrEmpty(studentName))
            {

                MessageBox.Show("The specified student ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkStudent = "SELECT COUNT(*) FROM IssueBooks WHERE studentID = @studentID";
            using (SqlCommand command = new SqlCommand(checkStudent, sqlConnection))
            {
                command.Parameters.AddWithValue("@studentID", primaryKeyValue);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {

                    MessageBox.Show("The student cannot be deleted because they have a book currently issued.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the student '{studentName}'?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                string deleteStudent = "UPDATE Students SET IsDeleted = 1 WHERE studentID = @primaryKeyValue";
                using (SqlCommand command = new SqlCommand(deleteStudent, sqlConnection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Student deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                tbDeleteStudentID.Clear();
            }
            sqlConnection.Close();
        }

        private void tbDeleteStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmAddStudent : Form
    {
        private readonly UCStudents ucStudents;
        
        public FrmAddStudent(UCStudents uCStudents)
        {
            InitializeComponent();
            ucStudents = uCStudents;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatAppearance.BorderSize = 0;

            AddUnderline(tbAddStudentFirstName);
            AddUnderline(tbAddStudentMiddleInitial);
            AddUnderline(tbAddStudentLastName);
            AddUnderline(tbAddStudentNumber);
            AddUnderline(tbEmail);
            AddUnderline(tbContactNumber);



            cbStudentYear.SelectedIndexChanged += (sender, e) =>
            {
                if (cbStudentYear.SelectedItem.ToString().Contains("Senior High School"))
                {
                    cbStudentCourse.Items.Clear();

                    string[] seniorHighCourses = { "GAS", "ABM", "HUMSS", "STEM", "TVL" };

                    foreach (string item in seniorHighCourses)
                    {
                        cbStudentCourse.Items.Add(item);
                    }
                }
                if (cbStudentYear.SelectedItem.ToString().Contains("Year - College"))
                {
                    cbStudentCourse.Items.Clear();

                    string[] collegeCourses = { "BSA", "BSBA", "BSCS", "BSCrim", "BSENTRE", "BSFM", "BSHM", "BSIT", "BSMKT", "BSTM" };

                    foreach (string item in collegeCourses)
                    {
                        cbStudentCourse.Items.Add(item);
                    }
                }
            };
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
        public void ClearTB()
        {
            tbAddStudentFirstName.Clear();
            tbAddStudentMiddleInitial.Clear();
            tbAddStudentLastName.Clear();
            tbAddStudentNumber.Clear();
            cbStudentYear.Text = " ";
            cbStudentCourse.Text = " ";
            tbEmail.Clear();
            tbContactNumber.Clear();
            dtpAddStudentDate.Value = DateTime.Today;
        }

        private void FrmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucStudents.LoadStudents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddStudentFirstName.Text) || string.IsNullOrEmpty(tbAddStudentLastName.Text) || string.IsNullOrEmpty(tbAddStudentNumber.Text) || string.IsNullOrEmpty(cbStudentYear.Text) || string.IsNullOrEmpty(cbStudentCourse.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbContactNumber.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentNumber = tbAddStudentNumber.Text;
            if (studentNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Student number must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contactNumber = tbContactNumber.Text;
            if (contactNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Contact number must contain only numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailAddress email = new MailAddress(tbEmail.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbAddStudentMiddleInitial.Text.Length > 1)
            {
                MessageBox.Show("Middle initial must be a single letter.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to add this student?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = new SqlConnection(SQLDatabaseUtils.StringConnection))
                {
                    sqlConnection.Open();
                    string sql = "SELECT COUNT(*) FROM Students WHERE studentNumber = @studentNumber AND IsDeleted = 0";
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", tbAddStudentNumber.Text);
                        int studentCount = (int)command.ExecuteScalar();
                        if (studentCount > 0)
                        {
                            MessageBox.Show("A student with the same student number already exists in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearTB();
                            return;
                        }
                    }
                    MessageBox.Show("Student added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string firstName = tbAddStudentFirstName.Text;
                    string middleInitial = string.IsNullOrEmpty(tbAddStudentMiddleInitial.Text) ? "" : char.IsLetter(tbAddStudentMiddleInitial.Text[0]) ? char.ToUpper(tbAddStudentMiddleInitial.Text[0]) + tbAddStudentMiddleInitial.Text.Substring(1) : "";
                    string lastName = tbAddStudentLastName.Text;

                    char[] firstNameArray = firstName.ToCharArray();
                    firstNameArray[0] = char.ToUpper(firstNameArray[0]);
                    firstName = new string(firstNameArray);

                    char[] lastNameArray = lastName.ToCharArray();
                    lastNameArray[0] = char.ToUpper(lastNameArray[0]);
                    lastName = new string(lastNameArray);

                    tbAddStudentFirstName.Text = firstName;
                    tbAddStudentMiddleInitial.Text = middleInitial;
                    tbAddStudentLastName.Text = lastName;

                    string query = "INSERT INTO Students (studentFirstName, studentMiddleInitial, studentLastName, studentNumber, studentYear, studentCourse, studentAddDate, studentEmail, studentContactNumber) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9)";
                    using (SqlCommand sqlCcommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCcommand.Parameters.AddWithValue("@value1", tbAddStudentFirstName.Text);
                        sqlCcommand.Parameters.AddWithValue("@value2", tbAddStudentMiddleInitial.Text);
                        sqlCcommand.Parameters.AddWithValue("@value3", tbAddStudentLastName.Text);
                        sqlCcommand.Parameters.AddWithValue("@value4", tbAddStudentNumber.Text);
                        sqlCcommand.Parameters.AddWithValue("@value5", cbStudentYear.Text);
                        sqlCcommand.Parameters.AddWithValue("@value6", cbStudentCourse.Text);
                        sqlCcommand.Parameters.AddWithValue("@value7", dtpAddStudentDate.Value);
                        sqlCcommand.Parameters.AddWithValue("@value8", tbEmail.Text);
                        sqlCcommand.Parameters.AddWithValue("@value9", tbContactNumber.Text);
                        int rowsAffected = sqlCcommand.ExecuteNonQuery();

                        ClearTB();
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void tbAddStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmUpdateStudent : Form
    {
       
        private readonly UCStudents ucStudents;
        public string[] collegeCourses { get; set; }
        public string[] seniorHighCourses { get; set; }
        public FrmUpdateStudent(UCStudents uCStudents)
        {
            InitializeComponent();
            ucStudents = uCStudents;

            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnSearchStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;

            AddUnderline(tbUpdateStudentFirstName);
            AddUnderline(tbUpdateStudentMiddleInitial);
            AddUnderline(tbUpdateStudentLastName);
            AddUnderline(tbUpdateStudentNumber);
            AddUnderline(tbUpdateEmail);
            AddUnderline(tbUpdateContactNumber);
            cbUpdateStudentYear.SelectedIndexChanged += (sender, e) =>
            {
                if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Senior High School"))
                {
                    cbUpdateStudentCourse.Items.Clear();

                    string[] seniorHighCourses = { "GAS", "ABM", "HUMSS", "STEM", "TVL" };

                    foreach (string item in seniorHighCourses)
                    {
                        cbUpdateStudentCourse.Items.Add(item);
                    }
                }
                if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Year - College"))
                {
                    cbUpdateStudentCourse.Items.Clear();

                    string[] collegeCourses = { "BSA", "BSBA", "BSCS", "BSCrim", "BSENTRE", "BSFM", "BSHM", "BSIT", "BSMKT", "BSTM" };

                    foreach (string item in collegeCourses)
                    {
                        cbUpdateStudentCourse.Items.Add(item);
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

        private void FrmUpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucStudents.LoadStudents();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();
                if (string.IsNullOrEmpty(tbSearchStudentID.Text))
                {
                    MessageBox.Show("Please enter a student ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbSearchStudentID.Text, out int studentID))
                {
                    MessageBox.Show("The student ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string checkBook = "SELECT IsDeleted FROM Students WHERE studentID = @studentID";
                using (SqlCommand command = new SqlCommand(checkBook, connection))
                {
                    command.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                    object isDeleted = command.ExecuteScalar();
                    if (isDeleted != null && Convert.ToInt32(isDeleted) == 1)
                    {
                        MessageBox.Show("This student is marked as deleted and cannot be updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string searchSql = "SELECT studentFirstName, studentMiddleInitial, studentLastName, studentNumber, studentYear, studentCourse, studentEmail, studentContactNumber FROM Students WHERE studentID = @studentID";
                using (SqlCommand searchCommand = new SqlCommand(searchSql, connection))
                {
                    searchCommand.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                    using (SqlDataReader reader = searchCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbUpdateStudentFirstName.Text = reader.GetString(0);
                            tbUpdateStudentMiddleInitial.Text = reader.GetString(1);
                            tbUpdateStudentLastName.Text = reader.GetString(2);
                            tbUpdateStudentNumber.Text = reader.GetString(3);
                            cbUpdateStudentYear.Text = reader.GetString(4);
                            cbUpdateStudentCourse.Text = reader.GetString(5);
                            tbUpdateEmail.Text = reader.GetString(6);
                            tbUpdateContactNumber.Text = reader.GetString(7);
                        }
                        else
                        {
                            MessageBox.Show("The specified student ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUpdateStudentFirstName.Text) || string.IsNullOrEmpty(tbUpdateStudentLastName.Text) || string.IsNullOrEmpty(tbUpdateStudentNumber.Text) || string.IsNullOrEmpty(cbUpdateStudentYear.Text) || string.IsNullOrEmpty(cbUpdateStudentCourse.Text) || string.IsNullOrEmpty(tbUpdateEmail.Text) || string.IsNullOrEmpty(tbUpdateContactNumber.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentNumber = tbUpdateStudentNumber.Text;
            if (studentNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Student number must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contactNumber = tbUpdateContactNumber.Text;
            if (contactNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Contact number must contain only numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailAddress email = new MailAddress(tbUpdateEmail.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbUpdateStudentMiddleInitial.Text.Length > 1)
            {
                MessageBox.Show("Middle initial must be a single letter.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Senior High School"))
            {
                if (cbUpdateStudentCourse.SelectedItem == null)
                {
                    MessageBox.Show("Invalid course selection for Senior High School year.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Year - College"))
            {
                if (cbUpdateStudentCourse.SelectedItem == null)
                {
                    MessageBox.Show("Invalid course selection for College year.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this student's record?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbUpdateStudentMiddleInitial.Text = string.IsNullOrEmpty(tbUpdateStudentMiddleInitial.Text) ? "" : char.IsLetter(tbUpdateStudentMiddleInitial.Text[0]) ? char.ToUpper(tbUpdateStudentMiddleInitial.Text[0]) + tbUpdateStudentMiddleInitial.Text.Substring(1) : "";
                using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
                {
                    connection.Open();
                    string updateSql = "UPDATE Students SET studentFirstName = @firstName, studentMiddleInitial = @middleInitial, studentLastName = @lastName, studentNumber = @studentNumber, studentYear = @year, studentCourse = @course, studentEmail = @email, studentContactNumber = @contactNumber WHERE studentID = @studentID";
                    using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@firstName", tbUpdateStudentFirstName.Text);
                        updateCommand.Parameters.AddWithValue("@middleInitial", tbUpdateStudentMiddleInitial.Text);
                        updateCommand.Parameters.AddWithValue("@lastName", tbUpdateStudentLastName.Text);
                        updateCommand.Parameters.AddWithValue("@studentNumber", tbUpdateStudentNumber.Text);
                        updateCommand.Parameters.AddWithValue("@course", cbUpdateStudentCourse.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@year", cbUpdateStudentYear.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@email", tbUpdateEmail.Text);
                        updateCommand.Parameters.AddWithValue("@contactNumber", tbUpdateContactNumber.Text);
                        updateCommand.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                        updateCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student record updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSearchStudentID.Clear();
                    tbUpdateStudentFirstName.Clear();
                    tbUpdateStudentMiddleInitial.Clear();
                    tbUpdateStudentLastName.Clear();
                    tbUpdateStudentNumber.Clear();
                    cbUpdateStudentYear.Text = " ";
                    cbUpdateStudentCourse.Text = " ";
                    tbUpdateEmail.Clear();
                    tbUpdateContactNumber.Clear();
                    connection.Close();
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbSearchStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUpdateStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUpdateContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmRenewIssuedBook : Form
    {
        private readonly UCIssueBooks ucIssueBooks;

        public FrmRenewIssuedBook(UCIssueBooks uCIssueBooks)
        {
            InitializeComponent();
            ucIssueBooks = uCIssueBooks;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnRenew.FlatAppearance.BorderSize = 0;

            AddUnderline(tbRenewBookName);
            AddUnderline(tbRenewStudentName);
            AddUnderline(tbRenewDueDate);
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
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int issueID;
            if (string.IsNullOrEmpty(tbIssueIDSearch.Text) || string.IsNullOrEmpty(tbRenewBookName.Text) || string.IsNullOrEmpty(tbRenewStudentName.Text) || string.IsNullOrEmpty(tbRenewDueDate.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                issueID = int.Parse(tbIssueIDSearch.Text);
            }

            DateTime newDueDate = dtpRenewNewDueDate.Value;
            DateTime currentDueDate;
            int renewTimes = 0;
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();
                string query1 = "SELECT renewTimes FROM IssueBooks WHERE issueID = @issueID";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@issueID", issueID);
                    renewTimes = (int)command.ExecuteScalar();
                }
                if (renewTimes == 3)
                {
                    MessageBox.Show("This book has already been renewed 3 times and cannot be renewed again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query2 = "SELECT dueDate FROM IssueBooks WHERE issueID = @issueID";
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@issueID", issueID);
                    currentDueDate = (DateTime)command.ExecuteScalar();
                }
                if (newDueDate < currentDueDate)
                {
                    MessageBox.Show("The new due date cannot be earlier than the current due date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TimeSpan duration = newDueDate.Subtract(currentDueDate);
                if (duration.Days > 7)
                {
                    MessageBox.Show("Issue can only be renewed within 7 days of its due date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to renew this book?\nCurrent Due Date: " + currentDueDate.ToShortDateString() + "\nNew Due Date: " + newDueDate.ToShortDateString(), "Confirm Renew", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query3 = "UPDATE IssueBooks SET dueDate = @newDueDate, renewTimes = renewTimes + 1 WHERE issueID = @issueID";
                    using (SqlCommand command1 = new SqlCommand(query3, connection))
                    {
                        command1.Parameters.AddWithValue("@issueID", issueID);
                        command1.Parameters.AddWithValue("@newDueDate", newDueDate);
                        command1.ExecuteNonQuery();
                    }
                    string query4 = "UPDATE IssueHistory SET dueDate = @newDueDate, renewTimes = renewTimes + 1 WHERE issueID = @issueID";
                    using (SqlCommand command2 = new SqlCommand(query4, connection))
                    {
                        command2.Parameters.AddWithValue("@issueID", issueID);
                        command2.Parameters.AddWithValue("@newDueDate", newDueDate);
                        command2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Issue successfully renewed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
                tbIssueIDSearch.Clear();
                tbRenewBookName.Clear();
                tbRenewStudentName.Clear();
                dtpRenewNewDueDate.Value = DateTime.Today;
            }
        }

        private void FrmRenewIssuedBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucIssueBooks.LoadIssue();
        }

        private void bnSearchIssueID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                if (string.IsNullOrEmpty(tbIssueIDSearch.Text))
                {
                    MessageBox.Show("Please enter an Issue ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int issueID = int.Parse(tbIssueIDSearch.Text);

                connection.Open();
                string query = "SELECT b.bookName, s.studentFirstName + ' ' + s.studentMiddleInitial + ' ' + s.studentLastName AS studentName, i.dueDate FROM IssueBooks i JOIN Books b ON i.bookID = b.bookID JOIN Students s ON i.studentID = s.studentID WHERE i.issueID = @issueID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@issueID", issueID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbRenewBookName.Text = reader["bookName"].ToString();
                            tbRenewStudentName.Text = reader["studentName"].ToString();
                            tbRenewDueDate.Text = Convert.ToDateTime(reader["dueDate"]).ToString("d");
                        }
                        else
                        {
                            MessageBox.Show("The specified issue ID was not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void tbIssueIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

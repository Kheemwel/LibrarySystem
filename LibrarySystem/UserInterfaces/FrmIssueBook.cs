using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmIssueBook : Form
    {
        private readonly UCIssueBooks ucIssueBooks;
       
        public FrmIssueBook(UCIssueBooks uCIssueBooks)
        {
            InitializeComponent();
            ucIssueBooks = uCIssueBooks;
            AddUnderline(tbIssueBookID);
            AddUnderline(tbIssueStudentID);

            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnIssueConfirm.FlatAppearance.BorderSize = 0;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIssueBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucIssueBooks.LoadIssue();
        }

        private void btnIssueConfirm_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();
                if (string.IsNullOrEmpty(tbIssueStudentID.Text) || string.IsNullOrEmpty(tbIssueBookID.Text))
                {
                    MessageBox.Show("Please enter a student ID and a book ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbIssueStudentID.Text, out int studentID) || !int.TryParse(tbIssueBookID.Text, out int bookID))
                {
                    MessageBox.Show("The student ID and book ID must be numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string countStudents = "SELECT COUNT(*) FROM Students WHERE studentID = @studentID";
                using (SqlCommand command = new SqlCommand(countStudents, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    int studentCount = (int)command.ExecuteScalar();
                    if (studentCount == 0)
                    {
                        MessageBox.Show("The specified student ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string checkStudent = "SELECT IsDeleted FROM Students WHERE studentID = @studentID";
                using (SqlCommand command = new SqlCommand(checkStudent, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    object isDeleted = command.ExecuteScalar();
                    if (isDeleted != null && Convert.ToInt32(isDeleted) == 1)
                    {
                        MessageBox.Show("This student is marked as deleted and cannot be issued.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string countBooks = "SELECT COUNT(*) FROM Books WHERE bookID = @bookID";
                using (SqlCommand command = new SqlCommand(countBooks, connection))
                {
                    command.Parameters.AddWithValue("@bookID", bookID);
                    int bookCount = (int)command.ExecuteScalar();
                    if (bookCount == 0)
                    {
                        MessageBox.Show("The specified book ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string checkBook = "SELECT IsDeleted FROM Books WHERE bookID = @bookID";
                using (SqlCommand command = new SqlCommand(checkBook, connection))
                {
                    command.Parameters.AddWithValue("@bookID", bookID);
                    object isDeleted = command.ExecuteScalar();
                    if (isDeleted != null && Convert.ToInt32(isDeleted) == 1)
                    {
                        MessageBox.Show("This book is marked as deleted and cannot be issued.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string checkBorrowedSql = "SELECT COUNT(*) FROM IssueBooks WHERE studentID = @studentID AND bookID = @bookID";
                using (SqlCommand command = new SqlCommand(checkBorrowedSql, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.Parameters.AddWithValue("@bookID", bookID);
                    int borrowedCount = (int)command.ExecuteScalar();
                    if (borrowedCount > 0)
                    {
                        MessageBox.Show("This student has already borrowed this book.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string checkStudentsSql = "SELECT COUNT(*) FROM Students WHERE studentID = @studentID AND studentCurrentlyRentedBooks >= 3";
                using (SqlCommand checkStudentsCommand = new SqlCommand(checkStudentsSql, connection))
                {
                    checkStudentsCommand.Parameters.AddWithValue("@studentID", tbIssueStudentID.Text);
                    int studentRentedBooks = (int)checkStudentsCommand.ExecuteScalar();
                    if (studentRentedBooks > 0)
                    {
                        MessageBox.Show("The student has already borrowed 3 books and cannot borrow any more.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (dtpIssueDate.Value > dtpDueDate.Value)
                {
                    MessageBox.Show("The due date must be after the issue date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtpIssueDate.Value == dtpDueDate.Value)
                {
                    MessageBox.Show("The due date must be after the issue date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtpDueDate.Value > dtpIssueDate.Value.AddDays(60))
                {
                    MessageBox.Show("The book can only be borrowed for 60 days.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string checkQuantitySql = "SELECT bookQuantity FROM Books WHERE bookID = @bookID";
                using (SqlCommand checkQuantityCommand = new SqlCommand(checkQuantitySql, connection))
                {
                    checkQuantityCommand.Parameters.AddWithValue("@bookID", tbIssueBookID.Text);
                    int quantity = (int)checkQuantityCommand.ExecuteScalar();
                    if (quantity == 0)
                    {
                        MessageBox.Show("The book you are trying to borrow is not available. Please select another book.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string studentFullName = "";
                string studentFullNameSql = "SELECT studentFirstName + ' ' + studentMiddleInitial + ' ' + studentLastName AS FullName FROM Students WHERE studentID = @studentID";
                using (SqlCommand studentFullNameCommand = new SqlCommand(studentFullNameSql, connection))
                {
                    studentFullNameCommand.Parameters.AddWithValue("@studentID", tbIssueStudentID.Text);
                    studentFullName = (string)studentFullNameCommand.ExecuteScalar();
                }
                string bookName = "";
                string bookNameSql = "SELECT bookName FROM Books WHERE bookID = @bookID";
                using (SqlCommand bookNameCommand = new SqlCommand(bookNameSql, connection))
                {
                    bookNameCommand.Parameters.AddWithValue("@bookID", tbIssueBookID.Text);
                    bookName = (string)bookNameCommand.ExecuteScalar();
                }
                DialogResult result = MessageBox.Show("Do you want to issue the book '" + bookName + "' to the student '" + studentFullName + "'?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "INSERT INTO IssueBooks (bookID, studentID, issueDate, dueDate) SELECT b.bookID, s.studentID, @issueDate, @dueDate FROM Books b INNER JOIN Students s ON s.studentID = @studentID WHERE b.bookID = @bookID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookID", tbIssueBookID.Text);
                        command.Parameters.AddWithValue("@studentID", tbIssueStudentID.Text);
                        command.Parameters.AddWithValue("@issueDate", dtpIssueDate.Value);
                        command.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);
                        command.ExecuteNonQuery();

                        string selectQuery = "SELECT @@IDENTITY";
                        SqlCommand commands = new SqlCommand(selectQuery, connection);
                        int issueID = Convert.ToInt32(commands.ExecuteScalar());
                        MessageBox.Show("Book issued successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string insertHistorySql = "INSERT INTO IssueHistory (bookID, studentID, issueDate, dueDate) SELECT b.bookID, s.studentID, @issueDate, @dueDate FROM Books b INNER JOIN Students s ON s.studentID = @studentID WHERE b.bookID = @bookID";
                    using (SqlCommand insertHistoryCommand = new SqlCommand(insertHistorySql, connection))
                    {
                        insertHistoryCommand.Parameters.AddWithValue("@bookID", tbIssueBookID.Text);
                        insertHistoryCommand.Parameters.AddWithValue("@studentID", tbIssueStudentID.Text);
                        insertHistoryCommand.Parameters.AddWithValue("@issueDate", dtpIssueDate.Value);
                        insertHistoryCommand.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);
                        insertHistoryCommand.ExecuteNonQuery();
                    }
                    string updateBooksSql = "UPDATE Books SET bookQuantity = bookQuantity - 1 WHERE bookID = @bookID";
                    using (SqlCommand updateBooksCommand = new SqlCommand(updateBooksSql, connection))
                    {
                        updateBooksCommand.Parameters.AddWithValue("@bookID", tbIssueBookID.Text);
                        updateBooksCommand.ExecuteNonQuery();
                    }

                    string updateStudentsSql = "UPDATE Students SET studentCurrentlyRentedBooks = studentCurrentlyRentedBooks + 1 WHERE studentID = @studentID";
                    using (SqlCommand updateStudentsCommand = new SqlCommand(updateStudentsSql, connection))
                    {
                        updateStudentsCommand.Parameters.AddWithValue("@studentID", tbIssueStudentID.Text);
                        updateStudentsCommand.ExecuteNonQuery();
                    }
                }
                tbIssueStudentID.Clear();
                tbIssueBookID.Clear();
                dtpIssueDate.Value = DateTime.Now;
                dtpDueDate.Value = DateTime.Now;
                connection.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbIssueBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIssueStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

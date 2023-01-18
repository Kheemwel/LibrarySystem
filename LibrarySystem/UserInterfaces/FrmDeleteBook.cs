using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmDeleteBook : Form
    {
        private readonly SqlConnection sqlConnection;
        private readonly UCBooks ucBooks;
        public FrmDeleteBook(UCBooks uCBooks)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(SQLDatabaseUtils.StringConnection);
            sqlConnection.Open();
            ucBooks = uCBooks;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            AddUnderline(tbDeleteBookID);
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

        private void FrmDeleteBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucBooks.LoadBooks();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDeleteBookID.Text))
            {

                MessageBox.Show("Please enter a book ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbDeleteBookID.Text, out int primaryKeyValue))
            {

                MessageBox.Show("The book ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectBook = "SELECT bookName FROM Books WHERE bookID = @primaryKeyValue";
            string bookName = "";
            using (SqlCommand command = new SqlCommand(selectBook, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookName = reader["bookName"].ToString();
                    }
                }
            }

            if (string.IsNullOrEmpty(bookName))
            {

                MessageBox.Show("The specified book ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkBook = "SELECT COUNT(*) FROM IssueBooks WHERE bookID = @primaryKeyValue";
            using (SqlCommand command = new SqlCommand(checkBook, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                int issuedCount = (int)command.ExecuteScalar();
                if (issuedCount > 0)
                {
                    MessageBox.Show("This book is currently issued and cannot be deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


            DialogResult result = MessageBox.Show($"Are you sure you want to delete the book '{bookName}'?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                string deleteBook = "UPDATE Books SET IsDeleted = 1 WHERE bookID = @primaryKeyValue";
                using (SqlCommand command = new SqlCommand(deleteBook, sqlConnection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Book deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                tbDeleteBookID.Clear();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbDeleteBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


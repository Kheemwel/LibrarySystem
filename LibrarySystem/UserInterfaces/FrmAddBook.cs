using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmAddBook : Form
    {
        private readonly UCBooks ucBooks;
        
        public FrmAddBook(UCBooks uCBooks)
        {
            InitializeComponent();
            ucBooks = uCBooks;
            AddUnderline(tbAddBookName);
            AddUnderline(tbAddAuthor);
            AddUnderline(tbAddQuantity);

            btnMinimize.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatAppearance.BorderSize = 0;
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

        private void FrmAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucBooks.LoadBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddBookName.Text) || string.IsNullOrEmpty(tbAddAuthor.Text) || string.IsNullOrEmpty(tbAddQuantity.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbAddQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to add this book?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = new SqlConnection(SQLDatabaseUtils.StringConnection))
                {
                    sqlConnection.Open();
                    string sql = "SELECT COUNT(*) FROM Books WHERE bookName = @bookName AND bookAuthor = @bookAuthor AND IsDeleted = 0";
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@bookName", tbAddBookName.Text);
                        command.Parameters.AddWithValue("@bookAuthor", tbAddAuthor.Text);
                        int bookCount = (int)command.ExecuteScalar();

                        if (bookCount > 0)
                        {
                            MessageBox.Show("A book with the same name and author already exists in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string query = "INSERT INTO Books (bookName, bookAuthor, bookQuantity, bookAddDate) VALUES (@value1, @value2, @value3, @value4)";
                        using (SqlCommand sqlCcommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCcommand.Parameters.AddWithValue("@value1", tbAddBookName.Text);
                            sqlCcommand.Parameters.AddWithValue("@value2", tbAddAuthor.Text);
                            sqlCcommand.Parameters.AddWithValue("@value3", tbAddQuantity.Text);
                            sqlCcommand.Parameters.AddWithValue("@value4", dtpAddBookDate.Value);

                            int rowsAffected = sqlCcommand.ExecuteNonQuery();
                            MessageBox.Show("Book added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbAddBookName.Clear();
                            tbAddAuthor.Clear();
                            tbAddQuantity.Clear();
                            dtpAddBookDate.Value = DateTime.Today;
                            sqlConnection.Close();
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbAddQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

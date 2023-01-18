using LibrarySystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCBooks : UserControl
    {
        private FrmAddBook frmAddBook;
        private FrmDeleteBook frmDeleteBook;
        private bool flag = false;
       

        public UCBooks()
        {
            InitializeComponent();

            tbSearchBook.BorderStyle = BorderStyle.None;
            Panel underline = new Panel
            {
                Size = new Size(tbSearchBook.Width, 1),
                Location = new Point(tbSearchBook.Left, tbSearchBook.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underline);

            btnAddBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnUpdateBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatAppearance.BorderSize = 0;


            btnAddBook.Image = btnAddBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnDeleteBook.Image = btnDeleteBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnUpdateBook.Image = btnUpdateBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSearchBook.Image = btnSearchBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
        }

        public void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();

                string query = "SELECT * FROM Books WHERE IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["bookAuthor"].ColumnName = "Author";
                    table.Columns["bookQuantity"].ColumnName = "Quantity";
                    table.Columns["bookAddDate"].ColumnName = "Date Added";


                    dgvBooks.DataSource = table;
                    dgvBooks.Columns["IsDeleted"].Visible = false;
                }
                connection.Close();
            }
        }

        private void UCBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            frmDeleteBook = new FrmDeleteBook(this);
            frmDeleteBook.ShowDialog();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

            FrmUpdateBook frmUpdateBook = new FrmUpdateBook(this);
            frmUpdateBook.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook = new FrmAddBook(this);
            frmAddBook.ShowDialog();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchBook.Text);
        }

        public void SearchAndHighlightRow(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("The search box cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!searchText.All(char.IsDigit))
            {
                MessageBox.Show("Search box must contain only numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row?.Cells["Book ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvBooks.CurrentCell = row.Cells["Book Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched book not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchBook_Enter(object sender, EventArgs e)
        {
            if (!flag)
            {
                tbSearchBook.Text = "";
                tbSearchBook.ForeColor = Color.Black;
            }
            flag = true;
        }

        private void tbSearchBook_Leave(object sender, EventArgs e)
        {
            if (tbSearchBook.Text.Length == 0 && flag)
            {
                tbSearchBook.Text = "Input your book ID here.";
                tbSearchBook.ForeColor = Color.Gray;
                flag = false;
            }
        }

        private void tbSearchBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

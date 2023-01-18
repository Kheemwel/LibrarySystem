using LibrarySystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCReturnBooks : UserControl
    {
        private bool flag = false;
        private FrmReturnBook frmReturnBook;
       
        public UCReturnBooks()
        {
            InitializeComponent();

            tbSearchReturn.BorderStyle = BorderStyle.None;
            Panel underline = new Panel
            {
                Size = new Size(tbSearchReturn.Width, 1),
                Location = new Point(tbSearchReturn.Left, tbSearchReturn.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underline);

            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnSearchReturn.FlatAppearance.BorderSize = 0;

            btnReturnBook.Image = btnReturnBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSearchReturn.Image = btnSearchReturn.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
        }

        private void tbSearchReturn_Enter(object sender, EventArgs e)
        {
            TBEmpty();
        }
        public void TBEmpty()
        {
            if (!flag)
            {
                tbSearchReturn.Text = "";
                tbSearchReturn.ForeColor = Color.Black;
            }
            flag = true;
        }
        private void tbSearchReturn_Leave(object sender, EventArgs e)
        {

            if (tbSearchReturn.Text.Length == 0 && flag)
            {
                tbSearchReturn.Text = "Input your return ID here.";
                tbSearchReturn.ForeColor = Color.Gray;
                flag = false;
            }
        }

        public void LoadReturn()
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();
                string Returnedquery = "SELECT rh.returnID, ih.issueID, rh.bookID, b.bookName, rh.studentID, s.studentFirstName, s.studentMiddleInitial, s.studentLastName, s.studentNumber, rh.issueDate, rh.dueDate, rh.returnDate, ih.renewTimes FROM ReturnHistory rh INNER JOIN Books b ON rh.bookID = b.bookID INNER JOIN Students s ON rh.studentID = s.studentID INNER JOIN IssueHistory ih ON rh.issueID = ih.issueID";


                using (SqlCommand command = new SqlCommand(Returnedquery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    table.Columns["issueID"].ColumnName = "Issue ID";
                    table.Columns["returnID"].ColumnName = "Return ID";
                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["issueDate"].ColumnName = "Issue Date";
                    table.Columns["dueDate"].ColumnName = "Due Date";
                    table.Columns["returnDate"].ColumnName = "Return Date";
                    table.Columns["renewTimes"].ColumnName = "Times Renewed";
                    dgvReturnedBooks.DataSource = table;
                }
                connection.Close();
            }

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
            foreach (DataGridViewRow row in dgvReturnedBooks.Rows)
            {
                if (row?.Cells["Return ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvReturnedBooks.CurrentCell = row.Cells["Book Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched return not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchReturn_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchReturn.Text);
            tbSearchReturn.Clear();
            TBEmpty();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            frmReturnBook = new FrmReturnBook(this);
            frmReturnBook.ShowDialog();
        }

        private void UCReturnBooks_Load(object sender, EventArgs e)
        {
            LoadReturn();
        }

        private void tbSearchReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

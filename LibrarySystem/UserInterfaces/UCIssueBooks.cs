using LibrarySystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCIssueBooks : UserControl
    {
       
        private FrmIssueBook frmIssueBook;
        private FrmRenewIssuedBook frmRenewIssuedBook;
        private bool flag = false;
        public UCIssueBooks()
        {
            InitializeComponent();
            tbSearchIssue.BorderStyle = BorderStyle.None;
            Panel underline = new Panel
            {
                Size = new Size(tbSearchIssue.Width, 1),
                Location = new Point(tbSearchIssue.Left, tbSearchIssue.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underline);

            btnIssueBook.FlatAppearance.BorderSize = 0;
            btnRenewBook.FlatAppearance.BorderSize = 0;
            btnSearchIssue.FlatAppearance.BorderSize = 0;

            btnIssueBook.Image = btnIssueBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnRenewBook.Image = btnRenewBook.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSearchIssue.Image = btnSearchIssue.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            LoadIssue();
        }
        private void UCIssueBooks_Load(object sender, EventArgs e)
        {
            LoadIssue();
        }
        public void LoadIssue()
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();

                string query = "SELECT i.issueID, i.bookID, b.bookName, i.studentID, s.studentFirstName, s.studentMiddleInitial, s.studentLastName, s.studentNumber, i.issueDate, i.dueDate, i.renewTimes FROM IssueBooks i INNER JOIN Books b ON i.bookID = b.bookID INNER JOIN Students s ON i.studentID = s.studentID"; ;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    table.Columns["issueID"].ColumnName = "Issue ID";
                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["issueDate"].ColumnName = "Issue Date";
                    table.Columns["dueDate"].ColumnName = "Due Date";
                    table.Columns["renewTImes"].ColumnName = "Times Renewed";

                    dgvIssuedBooks.DataSource = table;
                    foreach (DataGridViewRow row in dgvIssuedBooks.Rows)
                    {
                        if (row.Cells["Due Date"].Value != null)
                        {
                            DateTime dueDate = (DateTime)row.Cells["Due Date"].Value;
                            if (dueDate < DateTime.Now)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightCoral;
                            }
                        }
                    }
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
            foreach (DataGridViewRow row in dgvIssuedBooks.Rows)
            {
                if (row?.Cells["Issue ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvIssuedBooks.CurrentCell = row.Cells["Book Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched issue not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIssue();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmIssueBook = new FrmIssueBook(this);
            frmIssueBook.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRenewIssuedBook = new FrmRenewIssuedBook(this);
            frmRenewIssuedBook.ShowDialog();
        }

        private void btnSearchIssue_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchIssue.Text);
            tbSearchIssue.Clear();
            TBEmpty();
        }

        private void tbSearchIssue_Enter_1(object sender, EventArgs e)
        {
            if (!flag)
            {
                tbSearchIssue.Text = "";
                tbSearchIssue.ForeColor = Color.Black;
            }
            flag = true;
        }

        private void tbSearchIssue_Leave_1(object sender, EventArgs e)
        {
            TBEmpty();
        }
        public void TBEmpty()
        {
            if (tbSearchIssue.Text.Length == 0 && flag)
            {
                tbSearchIssue.Text = "Input your issue ID here.";
                tbSearchIssue.ForeColor = Color.Gray;
                flag = false;
            }
        }

        private void tbSearchIssue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
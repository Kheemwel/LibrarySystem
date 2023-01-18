using LibrarySystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCStudents : UserControl
    {
        private FrmAddStudent frmAddStudent;
        private FrmUpdateStudent frmUpdateStudent;
        private FrmDeleteStudent frmDeleteStudent;
        private bool flag = false;
       
        public UCStudents()
        {
            InitializeComponent();
            tbSearchStudent.BorderStyle = BorderStyle.None;
            Panel underline = new Panel
            {
                Size = new Size(tbSearchStudent.Width, 1),
                Location = new Point(tbSearchStudent.Left, tbSearchStudent.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underline);

            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnSearchStudent.FlatAppearance.BorderSize = 0;


            btnAddStudent.Image = btnAddStudent.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnDeleteStudent.Image = btnDeleteStudent.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnUpdateStudent.Image = btnUpdateStudent.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSearchStudent.Image = btnSearchStudent.Image.GetThumbnailImage(30, 30, null, IntPtr.Zero);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmUpdateStudent = new FrmUpdateStudent(this);
            frmUpdateStudent.ShowDialog();

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            frmDeleteStudent = new FrmDeleteStudent(this);

            frmDeleteStudent.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent = new FrmAddStudent(this);
            frmAddStudent.ShowDialog();
        }

        private void UCStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Students WHERE IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentYear"].ColumnName = "Year";
                    table.Columns["studentCourse"].ColumnName = "Course";
                    table.Columns["studentEmail"].ColumnName = "Email";
                    table.Columns["studentContactNumber"].ColumnName = "Contact Number";
                    table.Columns["studentAddDate"].ColumnName = "Date Added";
                    table.Columns["studentCurrentlyRentedBooks"].ColumnName = "Currently Rented Books";

                    dgvStudents.DataSource = table;
                    dgvStudents.Columns["IsDeleted"].Visible = false;
                }
                connection.Close();
            }
        }
        private void btnRefreshStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
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
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row?.Cells["Student ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvStudents.CurrentCell = row.Cells["First Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched Student not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbSearchStudent_Enter(object sender, EventArgs e)
        {
            if (!flag)
            {
                tbSearchStudent.Text = "";
                tbSearchStudent.ForeColor = Color.Black;
            }
            flag = true;
        }

        private void tbSearchStudent_Leave(object sender, EventArgs e)
        {
            TBEmpty();
        }
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchStudent.Text);
            tbSearchStudent.Clear();
            TBEmpty();
        }

        public void TBEmpty()
        {
            if (tbSearchStudent.Text.Length == 0 && flag)
            {
                tbSearchStudent.Text = "Input your student ID here.";
                tbSearchStudent.ForeColor = Color.Gray;
                flag = false;
            }
        }

        private void tbSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCDashboard : UserControl
    {
        private SqlConnection sqlConnection;
       
        public UCDashboard()
        {
            InitializeComponent();
            lblNumberOfBooks.BackColor = ColorTranslator.FromHtml("#31C1FF");
            lblNumberOfStudents.BackColor = ColorTranslator.FromHtml("#FFDE59");
            lblNumberOfCurrentlyIssuedBooks.BackColor = ColorTranslator.FromHtml("#7ED957");
            lblNumberOfAvailableBooks.BackColor = ColorTranslator.FromHtml("#FF5757");
            lblNumberOfOverDueBooks.BackColor = ColorTranslator.FromHtml("#FF914D");

            label1.BackColor = ColorTranslator.FromHtml("#31C1FF");
            label2.BackColor = ColorTranslator.FromHtml("#FFDE59");
            label5.BackColor = ColorTranslator.FromHtml("#7ED957");
            label4.BackColor = ColorTranslator.FromHtml("#FF5757");
            label3.BackColor = ColorTranslator.FromHtml("#FF914D");
        }
        public void LoadDashboard()
        {
            sqlConnection = new SqlConnection(SQLDatabaseUtils.StringConnection);
            using (SqlConnection connection = new SqlConnection(SQLDatabaseUtils.StringConnection))
            {
                connection.Open();

                string books = "SELECT COUNT(*) FROM Books WHERE IsDeleted = 0";
                SqlCommand command = new SqlCommand(books, connection);
                int count = (int)command.ExecuteScalar();

                string students = "SELECT COUNT(*) FROM Students WHERE IsDeleted = 0";
                command = new SqlCommand(students, connection);
                int count2 = (int)command.ExecuteScalar();

                string issuedBooks = "SELECT COALESCE(SUM(studentCurrentlyRentedBooks),0) FROM Students WHERE IsDeleted = 0";
                command = new SqlCommand(issuedBooks, connection);
                int count3 = (int)command.ExecuteScalar();

                string availableBooks = "SELECT COUNT(*) FROM Books WHERE bookQuantity > 0 AND IsDeleted = 0";
                command = new SqlCommand(availableBooks, connection);
                int count4 = (int)command.ExecuteScalar();

                string overdueBooks = "SELECT COUNT(*) FROM IssueBooks WHERE GETDATE() > dueDate";
                command = new SqlCommand(overdueBooks, connection);
                int count5 = (int)command.ExecuteScalar();

                lblNumberOfBooks.Text = count.ToString();
                lblNumberOfStudents.Text = count2.ToString();
                lblNumberOfCurrentlyIssuedBooks.Text = count3.ToString();
                lblNumberOfAvailableBooks.Text = count4.ToString();
                lblNumberOfOverDueBooks.Text = count4.ToString();
            }
        }
        public void RefreshData()
        {
            LoadDashboard();
        }
        private void UCDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}

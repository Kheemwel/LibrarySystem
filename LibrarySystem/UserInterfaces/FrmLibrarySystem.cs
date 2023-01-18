using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmLibrarySystem : Form
    {
        public FrmLibrarySystem()
        {
            InitializeComponent();

            btnAdmin.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnIssueBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;

            btnDashboard.BackColor = ColorTranslator.FromHtml("#243030");
            btnBooks.BackColor = ColorTranslator.FromHtml("#243030");
            btnStudents.BackColor = ColorTranslator.FromHtml("#243030");
            btnIssueBook.BackColor = ColorTranslator.FromHtml("#243030");
            btnReturnBook.BackColor = ColorTranslator.FromHtml("#243030");
            btnHistory.BackColor = ColorTranslator.FromHtml("#243030");
            btnExit.BackColor = ColorTranslator.FromHtml("#243030");
            btnAdmin.BackColor = ColorTranslator.FromHtml("#2c343c");

            btnAdmin.Image = btnAdmin.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnDashboard.Image = btnDashboard.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnBooks.Image = btnBooks.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnStudents.Image = btnStudents.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnIssueBook.Image = btnIssueBook.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnReturnBook.Image = btnReturnBook.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnHistory.Image = btnHistory.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);
            btnExit.Image = btnExit.Image.GetThumbnailImage(25, 25, null, IntPtr.Zero);


            menuPictureBox.BackColor = ColorTranslator.FromHtml("#243030");
        }
        private void btnAdmin_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnAdmin.Enabled)
            {
                btnAdmin.BackColor = ColorTranslator.FromHtml("#2c343c");
                btnAdmin.ForeColor = Color.White;
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard1.LoadDashboard();
            ucDashboard1.BringToFront();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ucBooks1.LoadBooks();
            ucBooks1.BringToFront();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ucStudents1.LoadStudents();
            ucStudents1.BringToFront();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            ucIssueBooks1.LoadIssue();
            ucIssueBooks1.BringToFront();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ucReturnBooks1.LoadReturn();
            ucReturnBooks1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Show();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ucHistory1.LoadHistory();
            ucHistory1.BringToFront();
        }
    }
}

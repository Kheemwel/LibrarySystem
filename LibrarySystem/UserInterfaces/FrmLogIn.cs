using LibrarySystem.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();

            //create database
            SQLDatabaseUtils.CreateDatabase();

            tbUsername.BorderStyle = BorderStyle.None;
            Panel underlineUsername = new Panel
            {
                Size = new Size(tbUsername.Width, 1),
                Location = new Point(tbUsername.Left, tbUsername.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underlineUsername);

            tbPassword.BorderStyle = BorderStyle.None;
            Panel underlinePassword = new Panel
            {
                Size = new Size(tbPassword.Width, 1),
                Location = new Point(tbPassword.Left, tbPassword.Bottom + 2),
                BackColor = Color.Gray
            };
            Controls.Add(underlinePassword);

            btnExit.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.BorderSize = 0;
            new GraphicsPath();
        }

        public void openfrmLibrarySystem()
        {
            Application.Run(new FrmLibrarySystem());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, user_pw;
            username = tbUsername.Text;
            user_pw = tbPassword.Text;

            string correctUsername = "admin";
            string correctPassword = "password";

            try
            {
                if (username == correctUsername && user_pw == correctPassword)
                {
                    //dispose this form
                    Dispose();

                    //create a thread for LibrarySystem form to open
                    Thread th = new Thread(openfrmLibrarySystem);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Clear();
                    tbPassword.Clear();

                    tbUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error connecting to the database!", "Error!");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

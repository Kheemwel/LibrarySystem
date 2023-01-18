namespace LibrarySystem
{
    partial class FrmUpdateStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpdateContactNumber = new System.Windows.Forms.TextBox();
            this.tbUpdateEmail = new System.Windows.Forms.TextBox();
            this.cbUpdateStudentCourse = new System.Windows.Forms.ComboBox();
            this.cbUpdateStudentYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUpdateStudentLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpdateStudentMiddleInitial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUpdateStudentNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateStudentFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Contact No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Email:";
            // 
            // tbUpdateContactNumber
            // 
            this.tbUpdateContactNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateContactNumber.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateContactNumber.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateContactNumber.Location = new System.Drawing.Point(235, 410);
            this.tbUpdateContactNumber.Name = "tbUpdateContactNumber";
            this.tbUpdateContactNumber.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateContactNumber.TabIndex = 8;
            this.tbUpdateContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUpdateContactNumber_KeyPress);
            // 
            // tbUpdateEmail
            // 
            this.tbUpdateEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateEmail.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateEmail.Location = new System.Drawing.Point(34, 410);
            this.tbUpdateEmail.Name = "tbUpdateEmail";
            this.tbUpdateEmail.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateEmail.TabIndex = 7;
            // 
            // cbUpdateStudentCourse
            // 
            this.cbUpdateStudentCourse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUpdateStudentCourse.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateStudentCourse.FormattingEnabled = true;
            this.cbUpdateStudentCourse.Location = new System.Drawing.Point(431, 318);
            this.cbUpdateStudentCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUpdateStudentCourse.Name = "cbUpdateStudentCourse";
            this.cbUpdateStudentCourse.Size = new System.Drawing.Size(177, 25);
            this.cbUpdateStudentCourse.TabIndex = 6;
            // 
            // cbUpdateStudentYear
            // 
            this.cbUpdateStudentYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUpdateStudentYear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateStudentYear.FormattingEnabled = true;
            this.cbUpdateStudentYear.Items.AddRange(new object[] {
            "Grade 11- Senior High School",
            "Grade 12 - Senior High School",
            "1st Year - College",
            "2nd Year - College",
            "3rd Year - College",
            "4th Year - College"});
            this.cbUpdateStudentYear.Location = new System.Drawing.Point(233, 318);
            this.cbUpdateStudentYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUpdateStudentYear.Name = "cbUpdateStudentYear";
            this.cbUpdateStudentYear.Size = new System.Drawing.Size(177, 25);
            this.cbUpdateStudentYear.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Year:";
            // 
            // tbUpdateStudentLastName
            // 
            this.tbUpdateStudentLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateStudentLastName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateStudentLastName.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateStudentLastName.Location = new System.Drawing.Point(431, 236);
            this.tbUpdateStudentLastName.Name = "tbUpdateStudentLastName";
            this.tbUpdateStudentLastName.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateStudentLastName.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Last Name:";
            // 
            // tbUpdateStudentMiddleInitial
            // 
            this.tbUpdateStudentMiddleInitial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateStudentMiddleInitial.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateStudentMiddleInitial.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateStudentMiddleInitial.Location = new System.Drawing.Point(233, 236);
            this.tbUpdateStudentMiddleInitial.Name = "tbUpdateStudentMiddleInitial";
            this.tbUpdateStudentMiddleInitial.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateStudentMiddleInitial.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(230, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Middle Initial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Course:";
            // 
            // tbUpdateStudentNumber
            // 
            this.tbUpdateStudentNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateStudentNumber.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateStudentNumber.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateStudentNumber.Location = new System.Drawing.Point(34, 318);
            this.tbUpdateStudentNumber.Name = "tbUpdateStudentNumber";
            this.tbUpdateStudentNumber.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateStudentNumber.TabIndex = 5;
            this.tbUpdateStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUpdateStudentNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Student No.:";
            // 
            // tbUpdateStudentFirstName
            // 
            this.tbUpdateStudentFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUpdateStudentFirstName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateStudentFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateStudentFirstName.Location = new System.Drawing.Point(34, 236);
            this.tbUpdateStudentFirstName.Name = "tbUpdateStudentFirstName";
            this.tbUpdateStudentFirstName.Size = new System.Drawing.Size(177, 24);
            this.tbUpdateStudentFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "First Name:";
            // 
            // tbSearchStudentID
            // 
            this.tbSearchStudentID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearchStudentID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchStudentID.ForeColor = System.Drawing.Color.Black;
            this.tbSearchStudentID.Location = new System.Drawing.Point(214, 122);
            this.tbSearchStudentID.Name = "tbSearchStudentID";
            this.tbSearchStudentID.Size = new System.Drawing.Size(213, 24);
            this.tbSearchStudentID.TabIndex = 0;
            this.tbSearchStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchStudentID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Student ID:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(574, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 73;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(606, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 71;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbTop.Location = new System.Drawing.Point(0, 0);
            this.pbTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(638, 32);
            this.pbTop.TabIndex = 72;
            this.pbTop.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Update Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(535, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "_________________________________________________________________________________" +
    "_______";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Location = new System.Drawing.Point(219, 150);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(200, 28);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(535, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "_________________________________________________________________________________" +
    "_______";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(219, 454);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(200, 28);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // FrmUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 506);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.tbSearchStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUpdateContactNumber);
            this.Controls.Add(this.tbUpdateEmail);
            this.Controls.Add(this.cbUpdateStudentCourse);
            this.Controls.Add(this.cbUpdateStudentYear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUpdateStudentLastName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUpdateStudentMiddleInitial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUpdateStudentNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUpdateStudentFirstName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUpdateStudent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUpdateContactNumber;
        private System.Windows.Forms.TextBox tbUpdateEmail;
        private System.Windows.Forms.ComboBox cbUpdateStudentCourse;
        private System.Windows.Forms.ComboBox cbUpdateStudentYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUpdateStudentLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUpdateStudentMiddleInitial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUpdateStudentNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateStudentFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateStudent;
    }
}
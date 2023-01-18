namespace LibrarySystem
{
    partial class FrmRenewIssuedBook
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
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRenewBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRenewStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRenewNewDueDate = new System.Windows.Forms.DateTimePicker();
            this.tbRenewDueDate = new System.Windows.Forms.TextBox();
            this.tbIssueIDSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bnSearchIssueID = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbTop.Location = new System.Drawing.Point(0, 0);
            this.pbTop.Margin = new System.Windows.Forms.Padding(2);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(414, 32);
            this.pbTop.TabIndex = 58;
            this.pbTop.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(350, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 60;
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
            this.btnExit.Location = new System.Drawing.Point(382, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 59;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Renew Issued Book";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "________________________________________";
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(111, 339);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(200, 28);
            this.btnRenew.TabIndex = 63;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Due Date:";
            // 
            // tbRenewBookName
            // 
            this.tbRenewBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRenewBookName.Enabled = false;
            this.tbRenewBookName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRenewBookName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRenewBookName.Location = new System.Drawing.Point(149, 202);
            this.tbRenewBookName.Name = "tbRenewBookName";
            this.tbRenewBookName.Size = new System.Drawing.Size(213, 24);
            this.tbRenewBookName.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Book Name:";
            // 
            // tbRenewStudentName
            // 
            this.tbRenewStudentName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRenewStudentName.Enabled = false;
            this.tbRenewStudentName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRenewStudentName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRenewStudentName.Location = new System.Drawing.Point(149, 236);
            this.tbRenewStudentName.Name = "tbRenewStudentName";
            this.tbRenewStudentName.Size = new System.Drawing.Size(213, 24);
            this.tbRenewStudentName.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Student Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "New Due Date:";
            // 
            // dtpRenewNewDueDate
            // 
            this.dtpRenewNewDueDate.CalendarFont = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRenewNewDueDate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRenewNewDueDate.Location = new System.Drawing.Point(149, 306);
            this.dtpRenewNewDueDate.Name = "dtpRenewNewDueDate";
            this.dtpRenewNewDueDate.Size = new System.Drawing.Size(213, 24);
            this.dtpRenewNewDueDate.TabIndex = 71;
            // 
            // tbRenewDueDate
            // 
            this.tbRenewDueDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRenewDueDate.Enabled = false;
            this.tbRenewDueDate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRenewDueDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRenewDueDate.Location = new System.Drawing.Point(149, 270);
            this.tbRenewDueDate.Name = "tbRenewDueDate";
            this.tbRenewDueDate.Size = new System.Drawing.Size(213, 24);
            this.tbRenewDueDate.TabIndex = 72;
            // 
            // tbIssueIDSearch
            // 
            this.tbIssueIDSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbIssueIDSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIssueIDSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbIssueIDSearch.Location = new System.Drawing.Point(149, 122);
            this.tbIssueIDSearch.Name = "tbIssueIDSearch";
            this.tbIssueIDSearch.Size = new System.Drawing.Size(213, 24);
            this.tbIssueIDSearch.TabIndex = 73;
            this.tbIssueIDSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIssueIDSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "Issue ID:";
            // 
            // bnSearchIssueID
            // 
            this.bnSearchIssueID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnSearchIssueID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSearchIssueID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSearchIssueID.ForeColor = System.Drawing.Color.White;
            this.bnSearchIssueID.Location = new System.Drawing.Point(111, 150);
            this.bnSearchIssueID.Margin = new System.Windows.Forms.Padding(2);
            this.bnSearchIssueID.Name = "bnSearchIssueID";
            this.bnSearchIssueID.Size = new System.Drawing.Size(200, 28);
            this.bnSearchIssueID.TabIndex = 75;
            this.bnSearchIssueID.Text = "Search Issue";
            this.bnSearchIssueID.UseVisualStyleBackColor = false;
            this.bnSearchIssueID.Click += new System.EventHandler(this.bnSearchIssueID_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "________________________________________";
            // 
            // FrmRenewIssuedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(414, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bnSearchIssueID);
            this.Controls.Add(this.tbIssueIDSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRenewDueDate);
            this.Controls.Add(this.dtpRenewNewDueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRenewBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRenewStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRenewIssuedBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRenewIssuedBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRenewIssuedBook_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRenewBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRenewStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRenewNewDueDate;
        private System.Windows.Forms.TextBox tbRenewDueDate;
        private System.Windows.Forms.TextBox tbIssueIDSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnSearchIssueID;
        private System.Windows.Forms.Label label8;
    }
}
namespace LibrarySystem
{
    partial class UCIssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIssueBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnRenewBook = new System.Windows.Forms.Button();
            this.tbSearchIssue = new System.Windows.Forms.TextBox();
            this.btnSearchIssue = new System.Windows.Forms.Button();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.White;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueBook.Image")));
            this.btnIssueBook.Location = new System.Drawing.Point(0, 0);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(120, 52);
            this.btnIssueBook.TabIndex = 13;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRenewBook
            // 
            this.btnRenewBook.BackColor = System.Drawing.Color.White;
            this.btnRenewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewBook.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnRenewBook.Image")));
            this.btnRenewBook.Location = new System.Drawing.Point(120, 0);
            this.btnRenewBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenewBook.Name = "btnRenewBook";
            this.btnRenewBook.Size = new System.Drawing.Size(120, 52);
            this.btnRenewBook.TabIndex = 14;
            this.btnRenewBook.Text = "Renew Issued Book";
            this.btnRenewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenewBook.UseVisualStyleBackColor = false;
            this.btnRenewBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearchIssue
            // 
            this.tbSearchIssue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchIssue.ForeColor = System.Drawing.Color.Gray;
            this.tbSearchIssue.Location = new System.Drawing.Point(463, 15);
            this.tbSearchIssue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchIssue.Name = "tbSearchIssue";
            this.tbSearchIssue.Size = new System.Drawing.Size(147, 24);
            this.tbSearchIssue.TabIndex = 16;
            this.tbSearchIssue.Text = "Input your issue ID here.";
            this.tbSearchIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchIssue.Enter += new System.EventHandler(this.tbSearchIssue_Enter_1);
            this.tbSearchIssue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchIssue_KeyPress);
            this.tbSearchIssue.Leave += new System.EventHandler(this.tbSearchIssue_Leave_1);
            // 
            // btnSearchIssue
            // 
            this.btnSearchIssue.BackColor = System.Drawing.Color.White;
            this.btnSearchIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIssue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchIssue.Image")));
            this.btnSearchIssue.Location = new System.Drawing.Point(614, 0);
            this.btnSearchIssue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchIssue.Name = "btnSearchIssue";
            this.btnSearchIssue.Size = new System.Drawing.Size(120, 52);
            this.btnSearchIssue.TabIndex = 15;
            this.btnSearchIssue.Text = "Search Issued Book";
            this.btnSearchIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchIssue.UseVisualStyleBackColor = false;
            this.btnSearchIssue.Click += new System.EventHandler(this.btnSearchIssue_Click);
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvIssuedBooks.AllowUserToResizeColumns = false;
            this.dgvIssuedBooks.AllowUserToResizeRows = false;
            this.dgvIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvIssuedBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssuedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssuedBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuedBooks.EnableHeadersVisualStyles = false;
            this.dgvIssuedBooks.GridColor = System.Drawing.Color.LightGray;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(0, 52);
            this.dgvIssuedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.RowHeadersVisible = false;
            this.dgvIssuedBooks.RowHeadersWidth = 51;
            this.dgvIssuedBooks.RowTemplate.Height = 24;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(734, 466);
            this.dgvIssuedBooks.TabIndex = 17;
            // 
            // UCIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvIssuedBooks);
            this.Controls.Add(this.tbSearchIssue);
            this.Controls.Add(this.btnSearchIssue);
            this.Controls.Add(this.btnRenewBook);
            this.Controls.Add(this.btnIssueBook);
            this.Name = "UCIssueBooks";
            this.Size = new System.Drawing.Size(734, 522);
            this.Load += new System.EventHandler(this.UCIssueBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnRenewBook;
        private System.Windows.Forms.TextBox tbSearchIssue;
        private System.Windows.Forms.Button btnSearchIssue;
        public System.Windows.Forms.DataGridView dgvIssuedBooks;
    }
}

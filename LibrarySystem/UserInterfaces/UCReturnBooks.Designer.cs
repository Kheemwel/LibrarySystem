namespace LibrarySystem
{
    partial class UCReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReturnBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearchReturn = new System.Windows.Forms.TextBox();
            this.btnSearchReturn = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.dgvReturnedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchReturn
            // 
            this.tbSearchReturn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchReturn.ForeColor = System.Drawing.Color.Gray;
            this.tbSearchReturn.Location = new System.Drawing.Point(463, 15);
            this.tbSearchReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchReturn.Name = "tbSearchReturn";
            this.tbSearchReturn.Size = new System.Drawing.Size(147, 24);
            this.tbSearchReturn.TabIndex = 21;
            this.tbSearchReturn.Text = "Input your return ID here.";
            this.tbSearchReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchReturn.Enter += new System.EventHandler(this.tbSearchReturn_Enter);
            this.tbSearchReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchReturn_KeyPress);
            this.tbSearchReturn.Leave += new System.EventHandler(this.tbSearchReturn_Leave);
            // 
            // btnSearchReturn
            // 
            this.btnSearchReturn.BackColor = System.Drawing.Color.White;
            this.btnSearchReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReturn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReturn.Image")));
            this.btnSearchReturn.Location = new System.Drawing.Point(614, 0);
            this.btnSearchReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchReturn.Name = "btnSearchReturn";
            this.btnSearchReturn.Size = new System.Drawing.Size(120, 52);
            this.btnSearchReturn.TabIndex = 20;
            this.btnSearchReturn.Text = "Search Returned Book";
            this.btnSearchReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchReturn.UseVisualStyleBackColor = false;
            this.btnSearchReturn.Click += new System.EventHandler(this.btnSearchReturn_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.White;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.Location = new System.Drawing.Point(0, 0);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(120, 52);
            this.btnReturnBook.TabIndex = 19;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dgvReturnedBooks
            // 
            this.dgvReturnedBooks.AllowUserToAddRows = false;
            this.dgvReturnedBooks.AllowUserToDeleteRows = false;
            this.dgvReturnedBooks.AllowUserToResizeColumns = false;
            this.dgvReturnedBooks.AllowUserToResizeRows = false;
            this.dgvReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReturnedBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturnedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnedBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnedBooks.EnableHeadersVisualStyles = false;
            this.dgvReturnedBooks.GridColor = System.Drawing.Color.LightGray;
            this.dgvReturnedBooks.Location = new System.Drawing.Point(0, 52);
            this.dgvReturnedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReturnedBooks.Name = "dgvReturnedBooks";
            this.dgvReturnedBooks.ReadOnly = true;
            this.dgvReturnedBooks.RowHeadersVisible = false;
            this.dgvReturnedBooks.RowHeadersWidth = 51;
            this.dgvReturnedBooks.RowTemplate.Height = 24;
            this.dgvReturnedBooks.Size = new System.Drawing.Size(734, 466);
            this.dgvReturnedBooks.TabIndex = 22;
            // 
            // UCReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvReturnedBooks);
            this.Controls.Add(this.tbSearchReturn);
            this.Controls.Add(this.btnSearchReturn);
            this.Controls.Add(this.btnReturnBook);
            this.Name = "UCReturnBooks";
            this.Size = new System.Drawing.Size(734, 522);
            this.Load += new System.EventHandler(this.UCReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchReturn;
        private System.Windows.Forms.Button btnSearchReturn;
        private System.Windows.Forms.Button btnReturnBook;
        public System.Windows.Forms.DataGridView dgvReturnedBooks;
    }
}

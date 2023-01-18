namespace LibrarySystem
{
    partial class UCHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.dgvIssuedHistory = new System.Windows.Forms.DataGridView();
            this.dgvReturnedHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Issued Books:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Returned Books:";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.White;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.Location = new System.Drawing.Point(-1, 0);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(150, 65);
            this.btnClearHistory.TabIndex = 20;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // dgvIssuedHistory
            // 
            this.dgvIssuedHistory.AllowUserToAddRows = false;
            this.dgvIssuedHistory.AllowUserToDeleteRows = false;
            this.dgvIssuedHistory.AllowUserToResizeColumns = false;
            this.dgvIssuedHistory.AllowUserToResizeRows = false;
            this.dgvIssuedHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvIssuedHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssuedHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssuedHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuedHistory.EnableHeadersVisualStyles = false;
            this.dgvIssuedHistory.GridColor = System.Drawing.Color.LightGray;
            this.dgvIssuedHistory.Location = new System.Drawing.Point(0, 65);
            this.dgvIssuedHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIssuedHistory.Name = "dgvIssuedHistory";
            this.dgvIssuedHistory.ReadOnly = true;
            this.dgvIssuedHistory.RowHeadersVisible = false;
            this.dgvIssuedHistory.RowHeadersWidth = 51;
            this.dgvIssuedHistory.RowTemplate.Height = 24;
            this.dgvIssuedHistory.Size = new System.Drawing.Size(918, 275);
            this.dgvIssuedHistory.TabIndex = 21;
            // 
            // dgvReturnedHistory
            // 
            this.dgvReturnedHistory.AllowUserToAddRows = false;
            this.dgvReturnedHistory.AllowUserToDeleteRows = false;
            this.dgvReturnedHistory.AllowUserToResizeColumns = false;
            this.dgvReturnedHistory.AllowUserToResizeRows = false;
            this.dgvReturnedHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReturnedHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturnedHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnedHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnedHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnedHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReturnedHistory.EnableHeadersVisualStyles = false;
            this.dgvReturnedHistory.GridColor = System.Drawing.Color.LightGray;
            this.dgvReturnedHistory.Location = new System.Drawing.Point(0, 376);
            this.dgvReturnedHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReturnedHistory.Name = "dgvReturnedHistory";
            this.dgvReturnedHistory.ReadOnly = true;
            this.dgvReturnedHistory.RowHeadersVisible = false;
            this.dgvReturnedHistory.RowHeadersWidth = 51;
            this.dgvReturnedHistory.RowTemplate.Height = 24;
            this.dgvReturnedHistory.Size = new System.Drawing.Size(918, 275);
            this.dgvReturnedHistory.TabIndex = 23;
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvReturnedHistory);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvIssuedHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(918, 653);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearHistory;
        public System.Windows.Forms.DataGridView dgvIssuedHistory;
        public System.Windows.Forms.DataGridView dgvReturnedHistory;
    }
}

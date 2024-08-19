namespace OOP_Project_SalesAndInventory
{
    partial class frmReportStockIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalStocksIn = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.lblCollections = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.ContractNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.Button2 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.ORNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalStocksIn
            // 
            this.lblTotalStocksIn.AutoSize = true;
            this.lblTotalStocksIn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStocksIn.Location = new System.Drawing.Point(181, 147);
            this.lblTotalStocksIn.Name = "lblTotalStocksIn";
            this.lblTotalStocksIn.Size = new System.Drawing.Size(44, 13);
            this.lblTotalStocksIn.TabIndex = 9;
            this.lblTotalStocksIn.Text = "C0001";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(13, 147);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(166, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Total Number of Stocks-In :";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Location = new System.Drawing.Point(2, 89);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(660, 2);
            this.Panel5.TabIndex = 67;
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollections.Location = new System.Drawing.Point(148, 99);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(259, 16);
            this.lblCollections.TabIndex = 8;
            this.lblCollections.Text = "Stocks-In for the Month of January";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(454, 47);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(122, 16);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "January 13, 2020";
            // 
            // ContractNo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ContractNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ContractNo.HeaderText = "Stocks-In";
            this.ContractNo.Name = "ContractNo";
            this.ContractNo.ReadOnly = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(-1, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(635, 18);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "_________________________________________________________";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 42);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 16);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "STOCKS-IN";
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // Button2
            // 
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Location = new System.Drawing.Point(563, 67);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 20);
            this.Button2.TabIndex = 69;
            this.Button2.Text = "&Close";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Stocks-In Report";
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(484, 67);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 20);
            this.Button1.TabIndex = 70;
            this.Button1.Text = "&Print";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Amount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Date In";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 110;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.lblTitle);
            this.Panel2.Location = new System.Drawing.Point(0, -1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(659, 66);
            this.Panel2.TabIndex = 68;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // DueDate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DueDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.DueDate.HeaderText = "Product";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 220;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(396, 39);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(140, 13);
            this.Label14.TabIndex = 10;
            this.Label14.Text = "___________________";
            this.Label14.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(356, 18);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "ANNA TRADING WHOLESALE AND RETAIL";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Black;
            this.Panel4.Location = new System.Drawing.Point(-9, 84);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(660, 2);
            this.Panel4.TabIndex = 52;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Label14);
            this.Panel3.Controls.Add(this.Label13);
            this.Panel3.Controls.Add(this.Label10);
            this.Panel3.Controls.Add(this.Label12);
            this.Panel3.Controls.Add(this.Label11);
            this.Panel3.Controls.Add(this.Label9);
            this.Panel3.Location = new System.Drawing.Point(15, 272);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(565, 91);
            this.Panel3.TabIndex = 49;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(426, 58);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(62, 13);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "Signature";
            this.Label13.Visible = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(84, 39);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(140, 13);
            this.Label10.TabIndex = 10;
            this.Label10.Text = "___________________";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(313, 14);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(90, 13);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Approved By :";
            this.Label12.Visible = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(114, 58);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(62, 13);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "Signature";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(1, 14);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(87, 13);
            this.Label9.TabIndex = 10;
            this.Label9.Text = "Prepared By :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.dgw);
            this.Panel1.Controls.Add(this.lblTotalStocksIn);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.lblCollections);
            this.Panel1.Controls.Add(this.lbldate);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(10, 92);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(628, 613);
            this.Panel1.TabIndex = 66;
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw.ColumnHeadersHeight = 24;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORNo,
            this.DueDate,
            this.Amount,
            this.ContractNo});
            this.dgw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.White;
            this.dgw.Location = new System.Drawing.Point(14, 175);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw.RowHeadersVisible = false;
            this.dgw.RowHeadersWidth = 25;
            this.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw.RowTemplate.Height = 18;
            this.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(575, 55);
            this.dgw.TabIndex = 48;
            // 
            // ORNo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ORNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ORNo.HeaderText = "Product Code";
            this.ORNo.Name = "ORNo";
            this.ORNo.ReadOnly = true;
            this.ORNo.Width = 110;
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // frmReportStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReportStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportStockIn";
            this.Load += new System.EventHandler(this.frmReportStockIn_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTotalStocksIn;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label lblCollections;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ContractNo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PrintDialog PrintDialog1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView dgw;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ORNo;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
    }
}
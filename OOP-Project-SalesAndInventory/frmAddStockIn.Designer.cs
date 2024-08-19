namespace OOP_Project_SalesAndInventory
{
    partial class frmAddStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockIn));
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalStocks = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblCurrentStocks = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(424, 22);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 33);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Cancel";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 256);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(525, 74);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(329, 22);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 33);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(116, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 21);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtQuantity);
            this.GroupBox1.Controls.Add(this.txtTotalStocks);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.lblCurrentStocks);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.lblPrice);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.lblDescription);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblProductCode);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 73);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(525, 177);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Stock-In Information";
            // 
            // txtTotalStocks
            // 
            this.txtTotalStocks.BackColor = System.Drawing.Color.White;
            this.txtTotalStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalStocks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStocks.Location = new System.Drawing.Point(362, 141);
            this.txtTotalStocks.Name = "txtTotalStocks";
            this.txtTotalStocks.Size = new System.Drawing.Size(137, 22);
            this.txtTotalStocks.TabIndex = 3;
            this.txtTotalStocks.Text = " ";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(270, 144);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(79, 15);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Total Stocks :";
            // 
            // lblCurrentStocks
            // 
            this.lblCurrentStocks.BackColor = System.Drawing.Color.White;
            this.lblCurrentStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentStocks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStocks.Location = new System.Drawing.Point(362, 88);
            this.lblCurrentStocks.Name = "lblCurrentStocks";
            this.lblCurrentStocks.Size = new System.Drawing.Size(137, 22);
            this.lblCurrentStocks.TabIndex = 3;
            this.lblCurrentStocks.Text = " ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(270, 89);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(94, 15);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Current Stocks :";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(116, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(137, 22);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = " ";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(16, 144);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(89, 15);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Enter Quantity :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 88);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 15);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Unit Price :";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(116, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(383, 22);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = " ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Description :";
            // 
            // lblProductCode
            // 
            this.lblProductCode.BackColor = System.Drawing.Color.White;
            this.lblProductCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(116, 33);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(383, 22);
            this.lblProductCode.TabIndex = 3;
            this.lblProductCode.Text = " ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Product Code :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.lblTitle);
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(549, 66);
            this.Panel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Stocks IN";
            // 
            // frmAddStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 334);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmAddStockIn";
            this.Text = "frmAddStockIn";
            this.Load += new System.EventHandler(this.frmAddStockIn_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label txtTotalStocks;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblCurrentStocks;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblProductCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblTitle;
    }
}
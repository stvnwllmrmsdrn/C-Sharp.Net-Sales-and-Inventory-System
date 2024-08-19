namespace OOP_Project_SalesAndInventory
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProductNo = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtStocksOnHand = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(2, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(661, 66);
            this.Panel1.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(3, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(275, 42);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Adding New Product";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.DarkGray;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(297, 154);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(26, 21);
            this.Button3.TabIndex = 4;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(461, 34);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 33);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(542, 34);
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
            this.GroupBox2.Location = new System.Drawing.Point(0, 229);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(635, 90);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // lblProductNo
            // 
            this.lblProductNo.BackColor = System.Drawing.Color.White;
            this.lblProductNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNo.Location = new System.Drawing.Point(130, 43);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(165, 22);
            this.lblProductNo.TabIndex = 2;
            this.lblProductNo.Text = " ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(81, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(130, 97);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(487, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BackColor = System.Drawing.Color.White;
            this.txtReorderLevel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLevel.Location = new System.Drawing.Point(452, 155);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(165, 22);
            this.txtReorderLevel.TabIndex = 7;
            this.txtReorderLevel.TextChanged += new System.EventHandler(this.txtReorderLevel_TextChanged);
            this.txtReorderLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReorderLevel_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(130, 181);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(165, 22);
            this.txtUnitPrice.TabIndex = 5;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(338, 158);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(94, 16);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Reorder Level :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 184);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 16);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Unit Price :";
            // 
            // txtStocksOnHand
            // 
            this.txtStocksOnHand.BackColor = System.Drawing.Color.White;
            this.txtStocksOnHand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStocksOnHand.Location = new System.Drawing.Point(452, 127);
            this.txtStocksOnHand.Name = "txtStocksOnHand";
            this.txtStocksOnHand.Size = new System.Drawing.Size(165, 22);
            this.txtStocksOnHand.TabIndex = 6;
            this.txtStocksOnHand.TextChanged += new System.EventHandler(this.txtStocksOnHand_TextChanged);
            this.txtStocksOnHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStocksOnHand_KeyPress);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.lblProductNo);
            this.GroupBox1.Controls.Add(this.txtDescription);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtReorderLevel);
            this.GroupBox1.Controls.Add(this.txtUnitPrice);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtStocksOnHand);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtCategory);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBarcode);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtProductCode);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(13, 83);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(635, 320);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Information";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(338, 130);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(109, 16);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Stocks on Hand :";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.White;
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(130, 153);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(165, 22);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            this.txtCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategory_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 156);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Category :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(130, 125);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(165, 22);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Barcode :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.White;
            this.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(130, 70);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(487, 22);
            this.txtProductCode.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Product Code :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 44);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 16);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Product No. :";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 410);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProduct";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lblProductNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtReorderLevel;
        internal System.Windows.Forms.TextBox txtUnitPrice;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtStocksOnHand;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCategory;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtProductCode;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
    }
}
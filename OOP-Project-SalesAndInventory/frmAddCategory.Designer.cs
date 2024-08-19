namespace OOP_Project_SalesAndInventory
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            this.Button2 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblCategoryNo = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(496, 39);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 33);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Cancel";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(130, 97);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(441, 22);
            this.txtDescription.TabIndex = 1;
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
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.lblTitle);
            this.Panel1.Location = new System.Drawing.Point(1, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(616, 66);
            this.Panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Adding New Category";
            // 
            // txtCatName
            // 
            this.txtCatName.BackColor = System.Drawing.Color.White;
            this.txtCatName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(130, 70);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(441, 22);
            this.txtCatName.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Category Name :";
            // 
            // lblCategoryNo
            // 
            this.lblCategoryNo.BackColor = System.Drawing.Color.White;
            this.lblCategoryNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoryNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryNo.Location = new System.Drawing.Point(130, 43);
            this.lblCategoryNo.Name = "lblCategoryNo";
            this.lblCategoryNo.Size = new System.Drawing.Size(156, 22);
            this.lblCategoryNo.TabIndex = 2;
            this.lblCategoryNo.Text = " ";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(415, 39);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 33);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.lblCategoryNo);
            this.GroupBox1.Controls.Add(this.txtDescription);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtCatName);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 82);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(586, 268);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Category Information";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Location = new System.Drawing.Point(0, 177);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(586, 90);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 44);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 16);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Category No. :";
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 358);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmAddCategory";
            this.Text = "frmAddCategory";
            this.Load += new System.EventHandler(this.frmAddCategory_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.TextBox txtCatName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblCategoryNo;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label6;
    }
}
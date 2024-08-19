namespace OOP_Project_SalesAndInventory
{
    partial class frmLoadCategory
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
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCatName
            // 
            this.txtCatName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(149, 29);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(447, 20);
            this.txtCatName.TabIndex = 0;
            this.txtCatName.TextChanged += new System.EventHandler(this.txtCatName_TextChanged);
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(3, 16);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(641, 215);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Category No";
            this.ColumnHeader1.Width = 101;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Category Name";
            this.ColumnHeader2.Width = 173;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Description";
            this.ColumnHeader3.Width = 339;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ListView1);
            this.GroupBox2.Location = new System.Drawing.Point(3, 75);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(647, 234);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(19, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 14);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Enter Category Name :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCatName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(3, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(647, 69);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // frmLoadCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 305);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmLoadCategory";
            this.Text = "frmLoadCategory";
            this.Load += new System.EventHandler(this.frmLoadCategory_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCatName;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}
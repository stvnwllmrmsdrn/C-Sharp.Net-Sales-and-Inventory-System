namespace OOP_Project_SalesAndInventory
{
    partial class frmLoadProduct
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ListView1);
            this.GroupBox2.Location = new System.Drawing.Point(1, 69);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(975, 315);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Enter Product Description :";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(188, 27);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(751, 20);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtProduct);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(1, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(972, 85);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(3, 16);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(969, 296);
            this.ListView1.TabIndex = 37;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Product No. ";
            this.ColumnHeader4.Width = 100;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Item Code";
            this.ColumnHeader5.Width = 110;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Product Description";
            this.ColumnHeader6.Width = 180;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Barcode";
            this.ColumnHeader7.Width = 110;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Category";
            this.ColumnHeader8.Width = 110;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Unit Price";
            this.ColumnHeader9.Width = 110;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "Stocks on Hand";
            this.ColumnHeader10.Width = 120;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Reorder Level";
            this.ColumnHeader11.Width = 120;
            // 
            // frmLoadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 382);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmLoadProduct";
            this.Text = "frmLoadProduct";
            this.Load += new System.EventHandler(this.frmLoadProduct_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtProduct;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader8;
        internal System.Windows.Forms.ColumnHeader ColumnHeader9;
        internal System.Windows.Forms.ColumnHeader ColumnHeader10;
        internal System.Windows.Forms.ColumnHeader ColumnHeader11;
    }
}
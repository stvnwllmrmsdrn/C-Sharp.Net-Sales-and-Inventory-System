namespace OOP_Project_SalesAndInventory
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.AutoSize = false;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton3.Text = "&Update";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(0, 40);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(921, 424);
            this.ListView1.TabIndex = 33;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Category No.";
            this.ColumnHeader1.Width = 93;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Category Name";
            this.ColumnHeader2.Width = 194;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Description";
            this.ColumnHeader3.Width = 311;
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.AutoSize = false;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton2.Text = "&Search";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.AutoSize = false;
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton4.Text = "&New";
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.AutoSize = false;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(65, 40);
            this.ToolStripButton1.Text = "Clos&e";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(20, 37);
            this.ToolStripLabel1.Text = "   ";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.ToolStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.ToolStripButton4,
            this.ToolStripButton3,
            this.ToolStripButton2,
            this.ToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(921, 40);
            this.ToolStrip1.TabIndex = 32;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(407, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 34;
            this.lblSearch.Text = "Search";
            this.lblSearch.Visible = false;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 464);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.Label lblSearch;
    }
}
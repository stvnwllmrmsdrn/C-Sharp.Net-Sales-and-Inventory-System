namespace OOP_Project_SalesAndInventory
{
    partial class frmStockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockOut));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkMonthly = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYearly = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.cmbYear1 = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cmbMonth);
            this.GroupBox3.Controls.Add(this.cmbYear1);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(8, 116);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(252, 96);
            this.GroupBox3.TabIndex = 45;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filter By";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 16);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Year :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Month :";
            // 
            // chkMonthly
            // 
            this.chkMonthly.AutoSize = true;
            this.chkMonthly.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonthly.Location = new System.Drawing.Point(11, 24);
            this.chkMonthly.Name = "chkMonthly";
            this.chkMonthly.Size = new System.Drawing.Size(73, 20);
            this.chkMonthly.TabIndex = 0;
            this.chkMonthly.Text = "Monhtly";
            this.chkMonthly.UseVisualStyleBackColor = true;
            this.chkMonthly.CheckedChanged += new System.EventHandler(this.chkMonthly_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkYearly);
            this.GroupBox1.Controls.Add(this.chkMonthly);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 59);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(251, 55);
            this.GroupBox1.TabIndex = 44;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select";
            // 
            // chkYearly
            // 
            this.chkYearly.AutoSize = true;
            this.chkYearly.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYearly.Location = new System.Drawing.Point(83, 24);
            this.chkYearly.Name = "chkYearly";
            this.chkYearly.Size = new System.Drawing.Size(63, 20);
            this.chkYearly.TabIndex = 0;
            this.chkYearly.Text = "Yearly";
            this.chkYearly.UseVisualStyleBackColor = true;
            this.chkYearly.CheckedChanged += new System.EventHandler(this.chkYearly_CheckedChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(349, 52);
            this.Panel1.TabIndex = 43;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 5);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(144, 42);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Stock-Out";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(136, 229);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(61, 31);
            this.Button3.TabIndex = 46;
            this.Button3.Text = "&Load";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(199, 229);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(64, 31);
            this.Button2.TabIndex = 47;
            this.Button2.Text = "Close";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cmbYear1
            // 
            this.cmbYear1.FormattingEnabled = true;
            this.cmbYear1.Location = new System.Drawing.Point(99, 25);
            this.cmbYear1.Name = "cmbYear1";
            this.cmbYear1.Size = new System.Drawing.Size(121, 28);
            this.cmbYear1.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(99, 54);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbMonth.TabIndex = 5;
            // 
            // frmStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStockOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStockOut_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox chkMonthly;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkYearly;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ComboBox cmbMonth;
        protected internal System.Windows.Forms.ComboBox cmbYear1;
    }
}
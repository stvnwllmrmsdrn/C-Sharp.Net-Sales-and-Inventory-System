namespace OOP_Project_SalesAndInventory
{
    partial class frmDailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailySales));
            this.Button3 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(137, 215);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(61, 31);
            this.Button3.TabIndex = 50;
            this.Button3.Text = "&Load";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(96, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(138, 22);
            this.dtp.TabIndex = 4;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(200, 215);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(61, 31);
            this.Button2.TabIndex = 51;
            this.Button2.Text = "Close";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location = new System.Drawing.Point(2, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(349, 52);
            this.Panel1.TabIndex = 48;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 5);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(147, 42);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Daily Sales";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.dtp);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(9, 67);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(252, 96);
            this.GroupBox3.TabIndex = 49;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filter By";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 16);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Select Date :";
            // 
            // frmDailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 257);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDailySales_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label5;
    }
}
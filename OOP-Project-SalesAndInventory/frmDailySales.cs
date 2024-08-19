using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_Project_SalesAndInventory
{
    public partial class frmDailySales : Form
    {
        public frmDailySales()
        {
            InitializeComponent();
        }

        private void frmDailySales_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmReportDailySales c = new frmReportDailySales();
            c.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

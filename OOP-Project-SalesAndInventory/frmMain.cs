using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace OOP_Project_SalesAndInventory
{
    public partial class frmMain : Form
    {
        private void CloseChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "frmHome")
                {
                }
                else
                {
                    frm.Close();
                }
            }
        }
        public frmMain()
        {   
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            IsMdiContainer = true;
            frmHome c = new frmHome();
            c.MdiParent = this;
            c.Show();    
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }
    private void ToolStripButton4_Click_1(object sender, EventArgs e)
        {
            CloseChildForm();
            frmStaff staff = new frmStaff();
            staff.Show();
            staff.MdiParent = this;
        }

        private void ToolStripButton3_Click_1(object sender, EventArgs e)
        {
            CloseChildForm();
            frmCategory cat = new frmCategory();
            cat.Show();
            cat.MdiParent = this;
        }

        private void ToolStripButton2_Click_1(object sender, EventArgs e)
        {
            CloseChildForm();
            frmProduct prod = new frmProduct();
            prod.Show();
            prod.MdiParent = this;
        }
        private void ToolStripButton5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("-https://www.PointOfSalesAndInventoryMonitoringSystem.com");
        }
        private void ToolStripButton7_Click_1(object sender, EventArgs e)
        {
            frmDailySales c = new frmDailySales();
            c.ShowDialog();
        }
        private void ToolStripButton6_Click_1(object sender, EventArgs e)
        {
            frmStockIn si = new frmStockIn();
            si.ShowDialog();
        }
        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmStockOut so = new frmStockOut();
            so.ShowDialog();           
        }
        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }
        private void StocksInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockIn c = new frmStockIn();
            c.ShowDialog();
        }
        private void StocksOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockOut c = new frmStockOut();
            c.ShowDialog();
        }
        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            frmStaff staff = new frmStaff();
            staff.Show();
            staff.MdiParent = this;
        }
        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            frmCategory cat = new frmCategory();
            cat.Show();
            cat.MdiParent = this;
        }
        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            frmProduct prod = new frmProduct();
            prod.Show();
            prod.MdiParent = this;
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout c = new frmAbout();
            c.ShowDialog();
        }
        private void HowDoIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit the Site for more information. -https://www.PointOfSalesAndInventoryMonitoringSystem.com");
        }
        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-https://www.PointOfSalesAndInventoryMonitoringSystem.com");
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close ?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            frmCustomer cus = new frmCustomer();
            cus.Show();
            cus.MdiParent = this;
        }
    }
}

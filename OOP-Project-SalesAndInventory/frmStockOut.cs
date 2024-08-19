using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace OOP_Project_SalesAndInventory
{
    public partial class frmStockOut : Form
    {
        public frmStockOut()
        {
            InitializeComponent();
        }

        private void frmStockOut_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button3;
            cmbMonth.Text = DateTime.Now.Month.ToString();
            cmbYear1.Text = DateTime.Now.Year.ToString();
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March");
            cmbMonth.Items.Add("April");
            cmbMonth.Items.Add("May");
            cmbMonth.Items.Add("June");
            cmbMonth.Items.Add("July");
            cmbMonth.Items.Add("August");
            cmbMonth.Items.Add("September");
            cmbMonth.Items.Add("October");
            cmbMonth.Items.Add("November");
            cmbMonth.Items.Add("December");
            cmbYear1.Items.Add("2000");
            cmbYear1.Items.Add("2001");
            cmbYear1.Items.Add("2002");
            cmbYear1.Items.Add("2003");
            cmbYear1.Items.Add("2004");
            cmbYear1.Items.Add("2005");
            cmbYear1.Items.Add("2006");
            cmbYear1.Items.Add("2007");
            cmbYear1.Items.Add("2008");
            cmbYear1.Items.Add("2009");
            cmbYear1.Items.Add("2010");
            cmbYear1.Items.Add("2011");
            cmbYear1.Items.Add("2012");
            cmbYear1.Items.Add("2013");
            cmbYear1.Items.Add("2014");
            cmbYear1.Items.Add("2015");
            cmbYear1.Items.Add("2016");
            cmbYear1.Items.Add("2017");
            cmbYear1.Items.Add("2018");
            cmbYear1.Items.Add("2019");
            cmbYear1.Items.Add("2020");
            cmbYear1.Items.Add("2021");
            cmbYear1.Items.Add("2022");
            cmbYear1.Items.Add("2023");
            cmbYear1.Items.Add("2024");
            cmbYear1.Items.Add("2025");
            cmbYear1.Items.Add("2000");
            cmbYear1.Items.Add("2000");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (cmbYear1.Text == "" && chkMonthly.Checked == true)
            {
                MessageBox.Show("Please Select Month", "Stock In ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbYear1.Text == "")
            {
                MessageBox.Show("Please Select Year", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkMonthly.Checked == false && chkYearly.Checked == false)
            {
                MessageBox.Show("Please Select one of the Checkbox. Either Monthly or Yearly.", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                frmReportStockOut c = new frmReportStockOut();
                c.ShowDialog();
            }

            
        }

        private void chkMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonthly.Checked == true)
            {
                chkYearly.CheckState = CheckState.Unchecked;
            }
        }

        private void chkYearly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYearly.Checked == true)
            {
                chkMonthly.CheckState = CheckState.Unchecked;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button3;
            cmbMonth.Text = DateTime.Now.Month.ToString();
            cmbYear.Text = DateTime.Now.Year.ToString();
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
            cmbYear.Items.Add("2000");
            cmbYear.Items.Add("2001");
            cmbYear.Items.Add("2002");
            cmbYear.Items.Add("2003");
            cmbYear.Items.Add("2004");
            cmbYear.Items.Add("2005");
            cmbYear.Items.Add("2006");
            cmbYear.Items.Add("2007");
            cmbYear.Items.Add("2008");
            cmbYear.Items.Add("2009");
            cmbYear.Items.Add("2010");
            cmbYear.Items.Add("2011");
            cmbYear.Items.Add("2012");
            cmbYear.Items.Add("2013");
            cmbYear.Items.Add("2014");
            cmbYear.Items.Add("2015");
            cmbYear.Items.Add("2016");
            cmbYear.Items.Add("2017");
            cmbYear.Items.Add("2018");
            cmbYear.Items.Add("2019");
            cmbYear.Items.Add("2020");
            cmbYear.Items.Add("2021");
            cmbYear.Items.Add("2022");
            cmbYear.Items.Add("2023");
            cmbYear.Items.Add("2024");
            cmbYear.Items.Add("2025");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "" && chkMonthly.Checked == true)
            {
                MessageBox.Show("Please Select Month", "Stock In ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbYear.Text == "")
            {
                MessageBox.Show("Please Select Year", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkMonthly.Checked == false && chkYearly.Checked == false)
            {
                MessageBox.Show("Please Select one of the Checkbox. Either Monthly or Yearly.", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmReportStockIn c = new frmReportStockIn();
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
    }
}

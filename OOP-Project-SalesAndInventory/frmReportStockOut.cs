using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace OOP_Project_SalesAndInventory
{
    public partial class frmReportStockOut : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        string strMonthNo;
        int y;

        private void MonthNumber()
        {
            frmStockOut c = new frmStockOut();
            switch (c.cmbMonth.Text)
            {
                case "January":
                    strMonthNo = "January";
                    break;
                case "Febraury":
                    strMonthNo = "Febraury";
                    break;
                case "March":
                    strMonthNo = "March";
                    break;
                case "April":
                    strMonthNo = "April";
                    break;
                case "May":
                    strMonthNo = "May";
                    break;
                case "June":
                    strMonthNo = "June";
                    break;
                case "July":
                    strMonthNo = "July";
                    break;
                case "August":
                    strMonthNo = "August";
                    break;
                case "September":
                    strMonthNo = "September";
                    break;
                case "October":
                    strMonthNo = "October";
                    break;
                case "November":
                    strMonthNo = "November";
                    break;
                case "December":
                    strMonthNo = "December";
                    break;
                default:
                    strMonthNo = "00";
                    break;
            }
        }
        private void LoadStockOutReport()
        {
            MonthNumber();
            double totStockOut;
            double totSales;
            OleDbCommand command = new OleDbCommand();
            try
            {
                connection.Open();
                frmStockOut c = new frmStockOut();
                if (c.chkMonthly.Checked == true)
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * From QueryDailySales WHERE Expr2 AND TDate LIKE '" + c + "%' AND TDate LIKE '%" + c.cmbYear1.Text + "' ORDER BY TDate";
                }
                else
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM QueryDailySales WHERE Expr2 AND TDate LIKE '%" + c.cmbYear1.Text + "' ORDER BY TDate";
                }
                OleDbDataReader dr = command.ExecuteReader();
                dgw.Rows.Clear();
                totStockOut  = 0.0;
                totSales = 0.0;
                y = 0;
                while (dr.Read() == true)
                {
                    dgw.Rows.Add(dr["ProductCode"], dr["Description"], dr["TDate"], dr["SumOfQuantity"], dr["ItemPrice"], dr["Expr1"]);
                    y += 17;
                    totStockOut += Convert.ToInt32(dr["SumOfQuantity"].ToString());
                    totSales += Convert.ToInt32(dr["ItemPrice"].ToString());
                }
                dgw.Height += y;
                lblTotalStocksIn.Text = totStockOut.ToString();
                lblSales.Text = totSales.ToString();
                Panel3.Location = new Point (Panel3.Location.X, Panel3.Location.Y + y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public frmReportStockOut()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReportStockOut_Load(object sender, EventArgs e)
        {

            this.AcceptButton = this.Button1; 
            frmStockOut c = new frmStockOut();
            if (c.chkMonthly.Checked == true)
            {
                lblCollections.Text = "Stocks-Out for the Month of " +  + " " + c.cmbYear1.Text;
            }
            else if (c.chkYearly.Checked == true)
            {
                lblCollections.Text = "Stock-Out for the Year of " + c.cmbYear1.Text;
            }
            LoadStockOutReport();
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(Panel1.Width, Panel1.Height);
            Panel1.DrawToBitmap(bm, new Rectangle(0,0, Panel1.Width, Panel1.Height));
            e.Graphics.DrawImage(bm, 0, 40);
            PageSetupDialog aps = new PageSetupDialog();
            aps.Document = PrintDocument1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            PrintDialog1.Document = PrintDocument1;
            DialogResult BPress = PrintDialog1.ShowDialog();
            if (BPress == DialogResult.OK)
            {
                Panel1.Height += y;
                PrintDocument1.Print();
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

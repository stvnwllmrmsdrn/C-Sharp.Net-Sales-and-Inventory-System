using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
namespace OOP_Project_SalesAndInventory
{
    public partial class frmReportDailySales : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        int y;

        private void LoadStockOutReport()
        {
            double totStockOut, totSales;

            try 
            {
                connection.Open();
                frmDailySales c= new frmDailySales();
                string sql = "SELECT * FROM QueryDailySales WHERE Expr2 AND TDate LIKE '%" + c.dtp.Value.ToString("MMMM/dd/yyyy") +"' ORDER BY TDate"; 
                    OleDbCommand cmd = new OleDbCommand(sql, connection);
                OleDbDataReader dr = cmd.ExecuteReader();
                
                dgw.Rows.Clear();
                totStockOut = 0.0;
                totSales = 0.0;
                y = 0;

                while (dr.Read() == true)
                {
                    dgw.Rows.Add(dr["ProductCode"], dr["Description"], dr["TDate"], dr["SumOfQuantity"], dr["ItemPrice"], dr["Expr1"]);
                    y +=17;
                    totStockOut += Convert.ToInt32(dr["SumOfQuantity"]);
                    totSales += Convert.ToInt32(dr["ItemPrice"]) * Convert.ToInt32(dr["SumOfQuantity"]);
                }    
                    dgw.Height+=y;
                    lblTotalStocksIn.Text = totStockOut.ToString();
                    lblSales.Text = totSales.ToString();
                    Panel3.Location = new Point(Panel3.Location.X, Panel3.Location.Y + y);
                }
                catch (Exception ex)
           {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                }        }
        public frmReportDailySales()
        {
            InitializeComponent();
        }

        private void frmReportDailySales_Load(object sender, EventArgs e)
        {
            
            this.AcceptButton = this.Button1;
            frmDailySales c = new frmDailySales();
            lblCollections.Text = "Sales of " + ""  + c.dtp.Value.ToString("MMMM dd,yyyy");
            LoadStockOutReport();
            lbldate.Text = DateTime.Now.ToLongDateString(); 

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

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(Panel1.Width, Panel1.Height);
            Panel1.DrawToBitmap(bm, new Rectangle(0, 0, Panel1.Width, Panel1.Height));
            e.Graphics.DrawImage(bm, 0, 40);
            PageSetupDialog aps = new PageSetupDialog();
            aps.Document = PrintDocument1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

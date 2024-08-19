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
    public partial class frmReportStockIn : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        frmStockIn c = new frmStockIn();
        
        private void LoadStockInReport()
        {
            
            int y;
            double totStockIn;
            OleDbCommand command = new OleDbCommand();
            
            try
            {
                connection.Open();
                frmStockIn c = new frmStockIn();
                if (c.chkMonthly.Checked == true)
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from QueryStockIn WHERE ProductNo AND DATEIN LIKE '" +  + "%' AND DATEIN LIKE '%" + c.cmbYear.Text + "'ORDER BY DateIn";
                    
                }
                else
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from QueryStockIn WHERE ProductNo AND DATEIN LIKE '%" + c.cmbYear.Text + "' ORDER BY DateIn";
                }
                OleDbDataReader dr = command.ExecuteReader();
                dgw.Rows.Clear();
                y = 0;
                totStockIn = 0;
                while (dr.Read() == true)
                {
                    dgw.Rows.Add(dr["ProductCode"], dr["Description"], dr["DateIn"], dr["SumOfQuantity"]);
                    y += 17;
                    totStockIn += Convert.ToDouble(dr["SumOfQuantity"]);
                }
                dgw.Height += y;
                lblTotalStocksIn.Text = totStockIn.ToString();
                Panel3.Location = new Point(Panel3.Location.X, Panel3.Location.Y + y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public frmReportStockIn()
        {
            InitializeComponent();
        }

        private void frmReportStockIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button1;
            frmStockIn c = new frmStockIn();
            if (c.chkMonthly.Checked == true)
            {
                lblCollections.Text = "Stock-In for the Month of " + c.cmbMonth.Text + " " + c.cmbYear.Text;
            }
            else if (c.chkYearly.Checked == true)
            {
                lblCollections.Text = "Stock-In for the Year of " + c.cmbYear.Text;
            }
            LoadStockInReport();
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(Panel1.Width, Panel1.Height);
            Panel1.DrawToBitmap(bm, new Rectangle(0, 0, Panel1.Width, Panel1.Height));
            e.Graphics.DrawImage(bm, 50, 60);
            PageSetupDialog aps = new PageSetupDialog();
            aps.Document = PrintDocument1;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PrintDialog1.Document = PrintDocument1;
            DialogResult BPress = PrintDialog1.ShowDialog();
            if (BPress == DialogResult.OK)
            {
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

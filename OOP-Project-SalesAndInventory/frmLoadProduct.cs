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
    public partial class frmLoadProduct : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");
        public static class valueWrapper
        {
            public static string prodID { get; set; }
            public static bool add { get; set; }
            public static bool update { get; set; }
        }
        public void LoadProduct()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblProduct as P WHERE P.Description LIKE '" + txtProduct.Text + "%' ORDER BY P.DESCRIPTION";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["ProductNo"].ToString());
                    x.SubItems.Add(dr["ProductCode"].ToString());
                    x.SubItems.Add(dr["Description"].ToString());
                    x.SubItems.Add(dr["Barcode"].ToString());
                    x.SubItems.Add(dr["Category_ID"].ToString());
                    x.SubItems.Add(dr["Price"].ToString());
                    x.SubItems.Add(dr["StockOnHand"].ToString());
                    x.SubItems.Add(dr["ReorderLevel"].ToString());

                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public frmLoadProduct()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAddCustomer c = new frmAddCustomer();
            c.txtProductNo.Text = frmLoadProduct.valueWrapper.prodID;
            c.txtProductNo.Tag = frmLoadProduct.valueWrapper.prodID;
        }

        private void frmLoadProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}

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
    public partial class frmProduct : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        public static class valueWrapper
        {
            public static string productID { get; set; }
            public static bool add { get; set; }
            public static bool update { get; set; }
            public static string productcode { get; set; }
            public static string description { get; set; }
            public static string price { get; set; }
            public static string stock { get; set; }
        }

        public Boolean add = true;
        public Boolean update = false;

        public void LoadProduct()
        {
             try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT ProductNo, ProductCode, P.Description, Barcode, Price, StockOnHand, ReorderLevel, CategoryName FROM tblProduct as P, tblCategory as C WHERE C.Category_ID = P.Category_ID AND P.Description LIKE '" + lblSearch.Text + "%' ORDER BY P.DESCRIPTION";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["ProductNo"].ToString());
                    x.SubItems.Add(dr["ProductCode"].ToString());
                    x.SubItems.Add(dr["Description"].ToString());
                    x.SubItems.Add(dr["Barcode"].ToString());
                    x.SubItems.Add(dr["CategoryName"].ToString());
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
        public void LoadProduct1()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT ProductNo, ProductCode, P.Description, Barcode, Price, StockOnHand, ReorderLevel, CategoryName FROM tblProduct as P, tblCategory as C WHERE C.Category_ID = P.Category_ID AND C.Category_ID";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["ProductNo"].ToString());
                    x.SubItems.Add(dr["ProductCode"].ToString());
                    x.SubItems.Add(dr["Description"].ToString());
                    x.SubItems.Add(dr["Barcode"].ToString());
                    x.SubItems.Add(dr["CategoryName"].ToString());
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

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            LoadProduct1();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            
            valueWrapper.add = true;
            valueWrapper.update = false;
            add = true;
            update = false;
            frmAddProduct c = new frmAddProduct();
            c.txtCategory.Enabled = true;
            c.ShowDialog();
            ListView1.Items.Clear();
            LoadProduct1();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strSearch = Interaction.InputBox("Enter Product Description:", "Search Product");
            if (strSearch.Length >= 1)
            {
                lblSearch.Text = strSearch.Trim();
                LoadProduct();
            }
            else
            {
                strSearch = " ";
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
           try
            {
                if (ListView1.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Please select record to update", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    valueWrapper.add = false;
                    valueWrapper.update = true;
                    valueWrapper.productID = ListView1.SelectedItems[0].SubItems[0].Text;
                    add = false;
                    update = true;
                    frmAddProduct c = new frmAddProduct();
                    c.ShowDialog();
                    ListView1.Items.Clear();
                    
                    LoadProduct1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
            {
                try
                {

                    if (ListView1.SelectedItems.Count < 1)
                    {
                        MessageBox.Show("Please select product or item to add stocks.", "ADD STOCK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        valueWrapper.add = false;
                        valueWrapper.update = true;
                        valueWrapper.productID = ListView1.SelectedItems[0].SubItems[0].Text;
                        valueWrapper.productcode = ListView1.SelectedItems[0].SubItems[1].Text;
                        valueWrapper.description = ListView1.SelectedItems[0].SubItems[2].Text;
                        valueWrapper.price = ListView1.SelectedItems[0].SubItems[5].Text;
                        valueWrapper.stock = ListView1.SelectedItems[0].SubItems[6].Text;
                        add = false;
                        update = true;
                       frmAddStockIn c = new frmAddStockIn();
                        c.ShowDialog();
                        ListView1.Items.Clear();
                        LoadProduct1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

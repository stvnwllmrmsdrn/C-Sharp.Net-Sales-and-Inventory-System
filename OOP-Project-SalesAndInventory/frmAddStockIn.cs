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
    public partial class frmAddStockIn : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");
       
        private void getinfo() 
        {
            lblProductCode.Text = frmProduct.valueWrapper.productID;
            lblDescription.Text = frmProduct.valueWrapper.description;
            lblPrice.Text = frmProduct.valueWrapper.price;
            lblCurrentStocks.Text = frmProduct.valueWrapper.stock;
        }
        private void AddStockIn()
        {
            if (txtQuantity.Text == "" || txtTotalStocks.Text == "")
            {
                MessageBox.Show("Please complete the information", "RETRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tblStockIn(ProductNo, Quantity, DateIn) VALUES('" + lblProductCode.Text + "', '" + txtQuantity.Text + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
                    OleDbDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Stock Successfully Added", "ADD STOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateProductQuantity();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }
        }
        private void UpdateProductQuantity()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                frmAddProduct c = new frmAddProduct();
                command.CommandText = "UPDATE tblProduct SET StockOnHand = '" + txtTotalStocks.Text + "' WHERE CInt(ProductNo) = '" + frmProduct.valueWrapper.productID + "'";
                OleDbDataReader dr = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public frmAddStockIn()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddStockIn();
            frmProduct c = new frmProduct();
            c.LoadProduct1();
            
        }

        private void frmAddStockIn_Load(object sender, EventArgs e)
        {
        this.AcceptButton = this.Button1;
        getinfo();
        txtQuantity.Text = "";
        txtTotalStocks.Text = "";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtTotalStocks.Text = (Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(lblCurrentStocks.Text)).ToString();
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

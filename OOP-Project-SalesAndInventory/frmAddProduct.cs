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
    public partial class frmAddProduct : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        public void GetProductNo()
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT PRODUCTNO FROM TBLPRODUCT ORDER BY PRODUCTNO DESC";
                OleDbDataReader dr = command.ExecuteReader();
                {
                    if (dr.Read() == true)
                    {
                        lblProductNo.Text = (Convert.ToInt32(dr["ProductNo"]) + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        private void LoadUpdateProduct()
        { /*UPDATE INFO*/
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT ProductNo, ProductCode, P.Description, Barcode, P.Category_ID, CategoryName, Price, StockOnHand, ReorderLevel FROM tblProduct as P, tblCategory as C WHERE C.Category_ID = P.Category_ID AND CInt(ProductNo) = '" + frmProduct.valueWrapper.productID + "'";
                OleDbDataReader dr = command.ExecuteReader();
                while (dr.Read() == true)
                { 
                lblProductNo.Text = dr["ProductNo"].ToString();
                txtProductCode.Text = dr["ProductCode"].ToString();
                txtDescription.Text = dr["Description"].ToString();
                txtBarcode.Text = dr["Barcode"].ToString();
                txtCategory.Text = dr["CategoryName"].ToString();
                txtCategory.Tag = dr["Category_ID"].ToString();
                txtUnitPrice.Text =dr["Price"].ToString();
                txtStocksOnHand.Text = dr["StockOnHand"].ToString();
                txtReorderLevel.Text = dr["ReorderLevel"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
         private void AddProduct()
        {
            //
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                frmStaff c = new frmStaff();
                command.CommandText = "INSERT INTO tblProduct(ProductCode, Description, Barcode, Price, StockOnHand, ReorderLevel, Category_ID) VALUES('" + txtProductCode.Text + "', '" + txtDescription.Text + "', '" + txtBarcode.Text +"', '" + txtUnitPrice.Text + "', '" + txtStocksOnHand.Text + "', '" + txtReorderLevel.Text + "', '" + txtCategory.Text + "')";
                OleDbDataReader dr = command.ExecuteReader();
                MessageBox.Show("Product successfully added.","Add Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AddStockIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
         private void AddStockIn()
         {
             try
             {
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 frmStaff c = new frmStaff();
                 command.CommandText = "INSERT INTO tblStockIn(ProductNo, Quantity, DateIn) Values('" + lblProductNo.Text + "','" + txtStocksOnHand.Text + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
                 OleDbDataReader dr = command.ExecuteReader();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }
         private void UpdateProduct()
         {
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 command.CommandText = "UPDATE tblProduct SET ProductCode = '" + txtProductCode.Text + "', Description = '" + txtDescription.Text + "', Barcode = '" + txtBarcode.Text + "', Price = '"  + txtUnitPrice.Text + "', StockOnHand = '" + txtStocksOnHand.Text + "', ReorderLevel = '" + txtReorderLevel.Text + "', Category_ID ='" + txtCategory.Tag + "' WHERE CInt(ProductNo)= '" + frmProduct.valueWrapper.productID + "'";
                 OleDbDataReader dr = command.ExecuteReader();
                 MessageBox.Show("Product Successfully Update.", "PRODUCT UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);         
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }
             connection.Close();
         }
         private void ClearProduct()
         {
        lblProductNo.Text = "";
        txtProductCode.Text = "";
        txtDescription.Text = "";
        txtBarcode.Text = "";
        txtCategory.Text = "";
        txtUnitPrice.Text = "";
        txtStocksOnHand.Text = "";
        txtReorderLevel.Text = "";
         }
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button1;
            if (frmProduct.valueWrapper.add == true)
            {
                Label1.Text = "Adding New Category";
                ClearProduct();
                GetProductNo();
            }
            else
            {
                Label1.Text = "Updating Category";
                LoadUpdateProduct();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmProduct c = new frmProduct();
            if (txtProductCode.Text == "" || txtDescription.Text == "" || txtCategory.Text == "" || txtBarcode.Text == "" || txtReorderLevel.Text == "" || txtStocksOnHand.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Please complete the information", "RETRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (frmProduct.valueWrapper.add == true)
            {
                AddProduct();
                this.Close();
            }
            else
            {
                UpdateProduct();
                c.LoadProduct();
                this.Close();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmLoadCategory c = new frmLoadCategory();
            c.ShowDialog();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtStocksOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtReorderLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtStocksOnHand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

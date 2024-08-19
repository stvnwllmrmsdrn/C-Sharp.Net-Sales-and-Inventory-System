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
    public partial class frmAddCustomer : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        private void AddCustomer()
        {
            /*ADD NEW STAFF*/
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                frmCustomer c = new frmCustomer();
                command.CommandText = "INSERT INTO tblCustomer (Lastname, Firstname, Middlename, Street, Baranggay, City, Province, ContactNo,ProductNo,Price,OrderType) VALUES('" + txtLastname.Text + "', '" + txtFirstname.Text + "', '" + txtMI.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtContractNo.Text + "', '"+txtProductNo.Text+"','"+txtPrice.Text +"', '"+comboBox1.Text+"')";
                OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("New Customer Successfully Added.", "ADD CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public void UpdateCustomer()
        {
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE tblCustomer SET Lastname = '" + txtLastname.Text + "', Firstname = '" + txtFirstname.Text + "', Middlename = '" + txtMI.Text + "', Street= '" + txtStreet.Text + "', Baranggay = '" + txtBarangay.Text + "', City = '" + txtCity.Text + "', Province = '" + txtProvince.Text + "', ContactNo = '" + txtContractNo.Text + "', ProductNo = '" + txtProductNo.Tag +"', Price = '" + txtPrice.Text + "', OrderType = '"+comboBox1.Text+"' WHERE CInt(Customer_ID) ='" + frmCustomer.valueWrapper.customerid +"'";
                OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("Staff Record Successfully Recorded Added.", "UPDATE STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void LoadUpdateCustomer()
        { /*UPDATE INFO*/
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Customer_ID, Lastname, Firstname, Middlename, Street, Baranggay, City, Province, ContactNo, P.ProductNo, P.Description, C.Price, OrderType FROM tblCustomer as C, tblProduct as P WHERE C.ProductNo = P.ProductNo AND CInt(Customer_ID) ='" + frmCustomer.valueWrapper.customerid + "'";
                OleDbDataReader dr = command.ExecuteReader();

                while (dr.Read() == true)
                {
                    lblStaffid.Text = dr["Customer_ID"].ToString();
                    txtLastname.Text = dr["Lastname"].ToString();
                    txtFirstname.Text = dr["Firstname"].ToString();
                    txtMI.Text = dr["Middlename"].ToString();
                    txtStreet.Text = dr["Street"].ToString();
                    txtBarangay.Text = dr["Baranggay"].ToString();
                    txtCity.Text = dr["City"].ToString();
                    txtProvince.Text = dr["Province"].ToString();
                    txtContractNo.Text = dr["ContactNo"].ToString();
                    txtProductNo.Text = dr["Description"].ToString();
                    txtProductNo.Tag = dr["ProductNo"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    comboBox1.Text = dr["OrderType"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                connection.Close();
            }
        }
        public void Clear()
        {
            lblStaffid.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMI.Text = "";
            txtStreet.Text = "";
            txtBarangay.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtContractNo.Text = "";
            txtProductNo.Text = "";
            txtPrice.Text = "";
            comboBox1.Text = "";

        }
        public void GetCustomerID()
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Customer_ID FROM tblCustomer ORDER BY Customer_ID DESC";
                OleDbDataReader dr = command.ExecuteReader();
                {
                    if (dr.Read() == true)
                    {
                        lblStaffid.Text = (Convert.ToInt32(dr["Customer_ID"]) + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

            this.AcceptButton = this.Button1;
            if (frmCustomer.valueWrapper.add == true)
            {
                lblTitle.Text = "Adding New Customer";
                Clear();
                GetCustomerID();
            }
            else
            {
                lblTitle.Text = "Updating Customer";
                LoadUpdateCustomer();
            }
            comboBox1.Items.Add("Deliver");
            comboBox1.Items.Add("Walk-in");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            if (txtLastname.Text == "" || txtFirstname.Text == "" || txtMI.Text == "" || txtStreet.Text == "" || txtProvince.Text == "" || txtBarangay.Text == "" || txtCity.Text == "" || txtContractNo.Text == "" || txtProductNo.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please complete the information", "RETRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (frmCustomer.valueWrapper.add == true)
            {
                AddCustomer();
                this.Close();
            }
            else
            {
                UpdateCustomer();
                c.LoadCustomer();
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContractNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Walk-in")
            {
                txtPrice.Enabled = true;
                txtPrice.Text = "";
                txtPrice.Focus();
            }
            else
            {
                txtPrice.Text = "";
                txtPrice.Enabled = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmLoadProduct c = new frmLoadProduct();
            c.ShowDialog();
        }

        private void txtContractNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}


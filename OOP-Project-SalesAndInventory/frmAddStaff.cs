using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace OOP_Project_SalesAndInventory
{
    public partial class frmAddStaff : Form
    {

        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        private void AddStaff()
        {
            /*ADD NEW STAFF*/
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                frmStaff c = new frmStaff();
                command.CommandText = "INSERT INTO tblStaff (Lastname, Firstname, Middlename, Street, Baranggay, City, Province, ContactNo, Username, Role, UPassword) VALUES('" + txtLastname.Text + "', '" + txtFirstname.Text + "', '" + txtMI.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtContractNo.Text + "', '" + txtUsername.Text + "', '" + txtRole.Text + "', '" + txtPassword.Text + "')";
                OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("New Staff Successfully Added.", "ADD STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
         public void UpdateStaff()
         {
             /*UPDATE STAFF INFO*/
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 command.CommandText = "UPDATE tblStaff SET Lastname = '" + txtLastname.Text + "', Firstname = '" + txtFirstname.Text + "', Middlename = '" + txtMI.Text + "', Street= '" + txtStreet.Text + "', Baranggay = '" + txtBarangay.Text + "', City = '" + txtCity.Text + "', Province = '" + txtProvince.Text + "', ContactNo = '" + txtContractNo.Text + "', Username ='" + txtUsername.Text + "', Role = '" + txtRole.Text + "', UPassword = '" + txtPassword.Text + "' WHERE Staff_ID =" + frmStaff.valueWrapper.staffId + "";
                 OleDbDataReader reader = command.ExecuteReader();
                 MessageBox.Show("Staff Record Successfully Recorded Added.", "UPDATE STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);         
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
             connection.Close();
         }
         private void LoadUpdateStaff()
         { /*UPDATE INFO*/
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 command.CommandText = "SELECT * FROM tblStaff WHERE Staff_ID LIKE'" + frmStaff.valueWrapper.staffId + "%'";
                 OleDbDataReader dr = command.ExecuteReader();
              
                 while (dr.Read()==true)
              {
                lblStaffid.Text = dr["Staff_ID"].ToString();
                txtLastname.Text = dr["Lastname"].ToString();
                txtFirstname.Text = dr["Firstname"].ToString();
                txtMI.Text = dr["Middlename"].ToString();
                txtStreet.Text = dr["Street"].ToString();
                txtBarangay.Text = dr["Baranggay"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtProvince.Text = dr["Province"].ToString();
                txtContractNo.Text =dr["ContactNo"].ToString();
                txtUsername.Text = dr["Username"].ToString();
                txtRole.Text = dr["Role"].ToString();
                txtPassword.Text = dr["UPassword"].ToString();
             
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
             connection.Close();
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
        txtUsername.Text = "";
        txtRole.Text = "";
        txtPassword.Text = "";
        }
        public void GetStaffNo()
        {

            try
            {   connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Staff_ID FROM TBLSTAFF ORDER BY Staff_ID DESC";
                OleDbDataReader dr = command.ExecuteReader();
                {
                    if (dr.Read() == true)
                    {
                        lblStaffid.Text = (Convert.ToInt32(dr["Staff_ID"]) + 1).ToString();
                    }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
            public frmAddStaff()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmStaff c = new frmStaff();
            if (txtLastname.Text == "" || txtFirstname.Text == "" || txtMI.Text == "" || txtStreet.Text == "" || txtProvince.Text == "" || txtBarangay.Text == "" || txtCity.Text == "" || txtContractNo.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtRole.Text == "")
            {
                MessageBox.Show("Please complete the information", "RETRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (frmStaff.valueWrapper.add == true)
            {
                AddStaff();
                this.Close();
            }
            else
            {
                UpdateStaff();
                c.LoadStaff();
                this.Close();
            }
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {

            this.AcceptButton = this.Button1;
            if (frmStaff.valueWrapper.add == true)
            {
                lblTitle.Text = "Adding New Staff";
                Clear();
                GetStaffNo();
            }
            else
            {
                lblTitle.Text = "Updating Staff";
                LoadUpdateStaff();
            }
            txtRole.Items.Add("ADMIN");
            txtRole.Items.Add("Manager");
            txtRole.Items.Add("Staff");
            txtRole.Items.Add("CEO");
            txtRole.Items.Add("Freshmen");




        }
                
        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblStaffid_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContractNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContractNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class frmLogin : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb;");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
            
            
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from tblStaff where Username = '" + txtUsername.Text + "' and UPassword = '" + txtPassword.Text +"'";
            OleDbDataReader dr = command.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Correct Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtUsername.Focus();
                frmMain c = new frmMain();
                c.tsslUser.Text = txtUsername.Text;
                c.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                connection.Close();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close ?", "Close Window", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button1;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

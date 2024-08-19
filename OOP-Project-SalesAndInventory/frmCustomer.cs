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
    public partial class frmCustomer : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        public static class valueWrapper
        {
            public static string customerid { get; set; }
            public static bool add { get; set; }
            public static bool update { get; set; }
        }

        public Boolean add = true;
        public Boolean update = false;


        public void LoadCustomer()
        {
            try
            {

                string lname;
                string fname;
                string mname;
                string fullname;
                string street;
                string city;
                string baranggay;
                string province;
                string address;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Customer_ID, Lastname, Firstname, Middlename, ContactNo, Street, Baranggay, City, Province, C.Price, OrderType, P.Description FROM tblCustomer as C, tblProduct as P WHERE C.ProductNo = P.ProductNo AND LASTNAME LIKE'" + lblSearch.Text + "%' ORDER BY LASTNAME";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["Customer_ID"].ToString());
                    lname = dr["Lastname"].ToString();
                    fname = dr["Firstname"].ToString();
                    mname = dr["Middlename"].ToString();
                    fullname = lname + ", " + fname + " " + mname;
                    x.SubItems.Add(fullname);
                    x.SubItems.Add(dr["ContactNo"].ToString());
                    street = dr["Street"].ToString();
                    baranggay = dr["Baranggay"].ToString();
                    city = dr["City"].ToString();
                    province = dr["Province"].ToString();
                    address = street + ", " + baranggay + ", " + city + " " + province;
                    x.SubItems.Add(address);
                    x.SubItems.Add(dr["Description"].ToString());
                    x.SubItems.Add(dr["Price"].ToString());
                    x.SubItems.Add(dr["OrderType"].ToString());

                   
                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public void LoadCustomer1()
        {
            try
            {

                string lname;
                string fname;
                string mname;
                string fullname;
                string street;
                string city;
                string baranggay;
                string province;
                string address;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Customer_ID, Lastname, Firstname, Middlename, ContactNo, Street, Baranggay, City, Province, Description, C.Price, OrderType FROM tblCustomer as C, tblProduct as P WHERE C.ProductNo = P.ProductNo AND CInt(C.ProductNo)";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["Customer_ID"].ToString());
                    lname = dr["Lastname"].ToString();
                    fname = dr["Firstname"].ToString();
                    mname = dr["Middlename"].ToString();
                    fullname = lname + ", " + fname + " " + mname;
                    x.SubItems.Add(fullname);
                    x.SubItems.Add(dr["ContactNo"].ToString());
                    street = dr["Street"].ToString();
                    baranggay = dr["Baranggay"].ToString();
                    city = dr["City"].ToString();
                    province = dr["Province"].ToString();
                    address = street + ", " + baranggay + ", " + city + " " + province;
                    x.SubItems.Add(address);
                    x.SubItems.Add(dr["Description"].ToString());
                    x.SubItems.Add(dr["Price"].ToString());
                    x.SubItems.Add(dr["OrderType"].ToString());
                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            LoadCustomer1();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strSearch = Interaction.InputBox("Enter Lastname of the Customer.", "Search Customer");
            if (strSearch.Length >= 1)
            {
                lblSearch.Text = strSearch.Trim();
                LoadCustomer();
            }
            else
            {
                strSearch = " ";
            }
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
            frmAddCustomer c = new frmAddCustomer();
            c.ShowDialog();
            ListView1.Items.Clear();
            LoadCustomer1();
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
                    valueWrapper.customerid = ListView1.SelectedItems[0].SubItems[0].Text;
                    add = false;
                    update = true;
                    frmAddCustomer c1 = new frmAddCustomer();
                    c1.ShowDialog();
                    ListView1.Items.Clear();
                    LoadCustomer1();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

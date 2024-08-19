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
    public partial class frmCategory : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");

        public static class valueWrapper
        {
            public static string categoryID { get; set; }
            public static bool add { get; set; }
            public static bool update { get; set; }
        }
        public Boolean add;
        public Boolean update;
        public void LoadCategories()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblCategory WHERE CategoryName LIKE'" + lblSearch.Text + "%' ORDER BY CategoryName";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["Category_ID"].ToString());
                    x.SubItems.Add(dr["CategoryName"].ToString());
                    x.SubItems.Add(dr["Description"].ToString());
                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public void LoadCategories1()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblCategory";
                OleDbDataReader dr = command.ExecuteReader();
                ListView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem x = new ListViewItem(dr["Category_ID"].ToString());
                    x.SubItems.Add(dr["CategoryName"].ToString());
                    x.SubItems.Add(dr["Description"].ToString());
                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            LoadCategories1();
            
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            valueWrapper.add = true;
            valueWrapper.update = false;
            add = true;
            update = false;
            frmAddCategory c = new frmAddCategory();
            c.ShowDialog();
            ListView1.Items.Clear();

            LoadCategories1();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strSearch = Interaction.InputBox("Enter Category Name:", "Search Category");
            if (strSearch.Length >= 1)
            {
                lblSearch.Text = strSearch.Trim();
                LoadCategories();
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
                    MessageBox.Show("Please select record to update", "UPDATE",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    valueWrapper.add = false;
                    valueWrapper.update = true;
                    valueWrapper.categoryID = ListView1.SelectedItems[0].SubItems[0].Text;

                    add = false;
                    update = true;
                    frmAddCategory c = new frmAddCategory();
                    c.ShowDialog();
                    ListView1.Items.Clear();
                    LoadCategories1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }


        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


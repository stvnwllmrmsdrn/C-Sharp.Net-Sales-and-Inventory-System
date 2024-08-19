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
    public partial class frmLoadCategory : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");
        public static class valueWrapper
        {
            public static string catid { get; set; }
            public static bool add { get; set; }
            public static bool update { get; set; }
        }
        public void LoadCategory()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblCategory WHERE CategoryName LIKE'" + txtCatName.Text + "%' ORDER BY CategoryName";
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
        public frmLoadCategory()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLoadCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAddProduct c = new frmAddProduct();
            c.txtCategory.Text = frmLoadCategory.valueWrapper.catid;
            c.txtCategory.Tag = frmLoadCategory.valueWrapper.catid;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}

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
    public partial class frmAddCategory : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\asus\Desktop\OOP-Project-SalesAndInventory_v2\OOP-Project-SalesAndInventory\OOP-Project-SalesAndInventory\OOP-DATABASE.accdb");


        public void GetCategoryNo()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT CATEGORY_ID FROM TBLCATEGORY ORDER BY CATEGORY_ID DESC";
                OleDbDataReader dr = command.ExecuteReader();
                {
                    if (dr.Read() == true)
                    {
                        lblCategoryNo.Text = (Convert.ToInt32(dr["Category_ID"]) + 1).ToString();
                    }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
}      
            public void LoadCategory()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblCategory WHERE Category_ID LIKE'" + frmCategory.valueWrapper.categoryID + "%'";
                OleDbDataReader dr = command.ExecuteReader();
                while (dr.Read() == true)
                {
                    lblCategoryNo.Text = dr["Category_ID"].ToString();
                    txtCatName.Text = dr["CategoryName"].ToString();
                    txtDescription.Text = dr["Description"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
        public void AddCategory()
        {
            try
            {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            frmStaff c = new frmStaff();
            command.CommandText = "INSERT INTO tblCategory(CategoryName, Description) VALUES('" + txtCatName.Text + "', '" + txtDescription.Text + "')";
            OleDbDataReader reader = command.ExecuteReader();
            MessageBox.Show("New Category Successfully Added.","ADD CATEGORY",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        catch(Exception ex)
            {
            MessageBox.Show(ex.ToString());
        }
}
        public void UpdateCategory()
        {   
            try 
            {
                connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 command.CommandText = "UPDATE tblCategory SET CategoryName= '" + txtCatName.Text + "', Description = '" + txtDescription.Text + "' WHERE Category_ID = " + frmCategory.valueWrapper.categoryID + "";
                 OleDbDataReader reader = command.ExecuteReader();
                 MessageBox.Show("Category Record Successfully Recorded Added.", "UPDATE CATEGORY",MessageBoxButtons.OK,MessageBoxIcon.Information);  
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
            connection.Close();
        }
        public void Clear()
        {
            lblCategoryNo.Text = "";
            txtDescription.Text = "";
            txtCatName.Text = "";
        }
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Button1;
            if (frmCategory.valueWrapper.add == true)
            {
                lblTitle.Text = "Adding New Staff";
                Clear();
                GetCategoryNo();
            }
            else
            {
                lblTitle.Text = "Updating Staff";
                LoadCategory();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddCategory c = new frmAddCategory();
            if (txtCatName.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please complete the information", "RETRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (frmCategory.valueWrapper.add == true)
            {
                AddCategory();
                this.Close();
            }
            else
            {
                UpdateCategory();
                c.LoadCategory();
                this.Close();
        }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
    


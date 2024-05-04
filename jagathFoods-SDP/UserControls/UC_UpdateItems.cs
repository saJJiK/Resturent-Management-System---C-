using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jagathFoods_SDP.UserControls
{
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String quary;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();

        }
        public void loadData()
        {
            quary = "select * from items";
            DataSet ds = fn.GetData(quary);
            guna2DataGridView1.DataSource = ds.Tables[0];


        }

        private void txtSeacrhItemUpd_TextChanged(object sender, EventArgs e)
        {
            quary = "select * from items where name like'" + txtSeacrhItemUpd.Text + "%'";
            DataSet ds = fn.GetData(quary);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            //select table data according to the Data GridView Columns. 
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            //fill the textbox according catchd data form the item gridview columns.
            txtItemCategoryUpd.Text = category;
            txtNameUpd.Text = name;
            txtPriceUpd.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            quary = "update items set name ='" + txtNameUpd.Text + "',category = '" + txtItemCategoryUpd.Text + "',price=" + txtPriceUpd.Text + " where ItemId=" + id + "";
            fn.SetData(quary);
            loadData();

            txtNameUpd.Clear();
            txtPriceUpd.Clear();
        }
    }
}

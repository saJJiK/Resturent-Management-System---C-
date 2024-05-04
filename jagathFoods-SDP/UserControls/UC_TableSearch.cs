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
    public partial class UC_TableSearch : UserControl
    {
        function fn = new function();
        String quary;
        public UC_TableSearch()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            quary = "select * from res";
            DataSet ds = fn.GetData(quary);


        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void txtSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            quary = "select * from res where Phone like'" + txtSearchPhoneNo.Text + "%'";
            DataSet ds = fn.GetData(quary);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_TableSearch_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }

}

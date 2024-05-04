using Guna.UI2.WinForms;
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
    public partial class UC_RemoveItem : UserControl
    {
        function fn = new function();
        String quary;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to Delete Items?";
            loadData();
        }
        public void loadData()
        {
            quary = "select * from items";
            DataSet ds = fn.GetData(quary);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            quary = "select items whare name like '" + txtSeacrhItemDel.Text + "%'";
            DataSet ds = fn.GetData(quary);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item ?", "Important message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                quary = "delete from items where ItemId =" + id + "";
                fn.SetData(quary);
                loadData();


            }
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {

            DelLabel.Text = "**Click on the row to delete the item";
        }
    }
}

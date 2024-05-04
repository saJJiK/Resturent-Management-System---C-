using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jagathFoods_SDP.UserControls
{
    public partial class UCAddItem : UserControl
    {
        function fn = new function();
        String query; // intialize query variable.

        public UCAddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('" + txtItemName.Text + "' , '" + txtItemCategory.Text + "' , '" + TxtItemPrice.Text + "')";
            fn.SetData(query);
            clearAll();//uses clear all method to clear data. 
            MessageBox.Show("Please restart the System to take an effect.", "War", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
        }
        public void clearAll()
        {
            txtItemCategory.SelectedIndex = -1;
            txtItemName.Clear();
            TxtItemPrice.Clear();

        }

        private void UCAddItem_Leave(object sender, EventArgs e)
        //clears every unsaved changes when leaving the Additem usercontrol.
        {
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

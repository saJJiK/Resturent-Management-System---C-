using jagathFoods_SDP.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jagathFoods_SDP
{
    public partial class ui_dashboard : Form
    {

        function fn = new function();
        String quary;
        public ui_dashboard()
        {
            InitializeComponent();
        }
        public ui_dashboard(String user)
        {
            InitializeComponent();
            //this hides button Remove Update and Additems from the guest. 
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
                btnTables.Hide();
            }
            else if (user == "admin")
            {

                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
                btnTables.Show();
            }
            else
            {
                //still nothing to show here.
            }
        }

        //back button in dashboard here.
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form fm = new Login();
            this.Hide();
            fm.Show();
        }
        //logout button is here. 
        private void btn_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            ucAddItem2.Visible = true;
            ucAddItem2.BringToFront();

        }

        private void ui_dashboard_Load(object sender, EventArgs e)
        {
            ucAddItem2.Visible = false;
            uC_UpdateItems1.Visible = false;
            ucTableRes2.Visible = false;
            uC_Placeorder1.Visible = false;
            uC_RemoveItem1.Visible = false;
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            ucTableRes2.Visible = true;
            ucTableRes2.BringToFront();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_Placeorder1);
            uC_Placeorder1.Visible = true;
            uC_Placeorder1.BringToFront();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }
    }
}

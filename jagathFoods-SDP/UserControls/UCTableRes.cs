using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Collections;
using System.Numerics;
using System.Xml.Linq;

namespace jagathFoods_SDP.UserControls
{
    public partial class UCTableRes : UserControl
    {
        function func = new function();
        public UCTableRes()
        {
            InitializeComponent();
        }

        private void UCTableRes_Load(object sender, EventArgs e)
        {
            uc_AddRes1.Visible = false;
            uC_TableSearch1.Visible = false;
        }

        private void tblSea_Click(object sender, EventArgs e)
        {
            uc_AddRes1.Visible = false;
            uC_TableSearch1.Visible = true;
            uC_TableSearch1.BringToFront();
        }

        private void tblres_Click(object sender, EventArgs e)
        {
            uc_AddRes1.Visible = true;
            uc_AddRes1.BringToFront();
        }
    }
}

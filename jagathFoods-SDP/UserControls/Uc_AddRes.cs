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
    public partial class Uc_AddRes : UserControl
    {
        function func = new function();
        string query;
        int res_tbno;
        public Uc_AddRes()
        {
            InitializeComponent();
        }

        private void btn_tb_Reserve_Click(object sender, EventArgs e)
        {
            string phone, name, res_in;
            int res_inH, res_inM, res_outH, res_outM;



            phone = txt_Reservation_Phone.Text;
            name = txt_Reservation_Name.Text;
            res_inH = int.Parse(combo_inH.Text);
            res_outH = int.Parse(combo_outH.Text);
            res_inM = int.Parse(combo_inM.Text);
            res_outM = int.Parse(combo_outM.Text);

            query = "insert into res (Phone,Name,res_inH,res_inM,res_outH,res_outM,table_no) values ('" + phone + "' , '" + name + "' , '" + res_inH + "', '" + res_inM + "','" + res_outH + "','" + res_outM + "', '" + res_tbno + "')";
            func.SetData(query);
            clearAll();
        }
        public void clearAll()
        {
            txt_Reservation_Phone.Text = "";
            txt_Reservation_Name.Text = "";
        }
    }
}

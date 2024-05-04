using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jagathFoods_SDP
{
    public partial class ui_signup : Form
    {
        public ui_signup()
        {
            InitializeComponent();
        }
        //using database config
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQL_SERVER;Initial Catalog=JagathFoods-SDP;Integrated Security=True");


        private void btnLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            String name, username, user_password;
            name = txtName.Text;
            username = txt_usr.Text;
            user_password = txt_pwd.Text;
            //add validation part is done here.
            if (name == "" && username == "" && user_password == "")
            {
                MessageBox.Show("Data fields cannot be empty");

            }
            else
            {
                //database connection and insertion is done here.
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users(name,username,password) VALUES ('" + name + "','" + username + "','" + user_password + "')";

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("user registration successful!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
                finally
                {
                    conn.Close();

                }
            }

        }

        private void ui_loginGuestCtrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ui_dashboard ds = new ui_dashboard("Guest");
            ds.Show();
            this.Hide();
        }
    }
}

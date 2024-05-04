using System.Data;
using System.Data.SqlClient;

namespace jagathFoods_SDP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQL_SERVER;Initial Catalog=JagathFoods-SDP;Integrated Security=True");
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form scr_signup = new ui_signup();
            scr_signup.Show();
            this.Hide();

        }

        private void btn_Guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ui_dashboard ds = new ui_dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username , user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "Select * from users where username = '"+username+"' AND password = '" + user_password+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0) {

                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    Form mainpanel = new ui_dashboard(username); 
                    mainpanel.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }
            catch {
                MessageBox.Show("Error");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
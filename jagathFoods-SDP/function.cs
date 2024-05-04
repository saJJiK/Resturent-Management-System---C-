using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagathFoods_SDP
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI\\MSSQL_SERVER;Initial Catalog=JagathFoods-SDP;Integrated Security=True";
            return con;
        }
        //get data from the query.
        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query; //passing query text
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
            da.Fill(ds);
             
            return ds;
            

        }
        //this code for edit data in the string query.
        public void SetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            //showing message for successful query.
            MessageBox.Show("Data Processed Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}

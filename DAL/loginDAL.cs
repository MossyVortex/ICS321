using BloodManagmentSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodManagmentSystem.DAL
{
    internal class loginDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL L)
        {
            bool isSuccess= false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", L.username);
                cmd.Parameters.AddWithValue("@password", L.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }





            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally 
            { conn.Close(); 
            
            }   

            return isSuccess;

        }

    }
}

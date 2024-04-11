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
    internal class userDAL
    {
        // a Static method for connecting the database 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        #region SELECT data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                conn.Open();
                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
            conn.Close();
            }
            
            return dt;
        }
        #endregion


        #region  INSERT data INTO database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO tbl_users(username,email,password,full_name,contact,address,added_date,image_name) VALUES (@username,@email,@password,@full_name,@contact,@address,@added_date,@image_name)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                conn.Open();
                int rows= cmd.ExecuteNonQuery();
                if (rows > 0)
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

        #endregion

        #region Update data in database (User Module)
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "UPDATE tbl_users SET username=@username,email=@email,password=@password,full_name=@full_name,contact=@contact,address=@address,added_date=@added_date,image_name=@image_name WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                conn.Open();
                
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
            {
                conn.Close();
            }

            return isSuccess;
        }

        #endregion

        #region DELETE data from database (User Module)
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "DELETE FROM tbl_users WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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





        #endregion


        #region Search 

        public DataTable Search(string keywords)
        {
           // create a connection to the data base.
            SqlConnection conn = new SqlConnection(myconnstrng);


            //create a new data table
            DataTable dt = new DataTable();



            // Code for searching Users

            try
            {
                String sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%"+keywords+ "%' OR full_name LIKE '%"+keywords+ "%' OR address LIKE '%"+keywords+"%'  ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);








            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally 
            { 
                conn.Close(); 
            
            }





            return dt;

        }








        #endregion



    }
}

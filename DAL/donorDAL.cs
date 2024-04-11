using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodManagmentSystem.BLL;

namespace BloodManagmentSystem.DAL
{
     class donorDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_donors";
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
        public bool Insert(donorBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO tbl_donors(first_name,last_name,email,contact,gender,address,blood_group,added_date,image_name,added_by) VALUES (@first_name,@last_name,@email,@contact,@gender,@address,@blood_group,@added_date,@image_name,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@gender", u.gender);
               
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@blood_group", u.blood_group);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

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


        #region Update data in database (Donor Module)
        public bool Update(donorBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "UPDATE tbl_donors SET first_name=@first_name,last_name=@last_name,email=@email,gender=@gender,contact=@contact,address=@address,blood_group=@blood_group,image_name=@image_name,added_by=@added_by WHERE donor_id=@donor_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@blood_group", u.blood_group);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@donor_id", u.donor_id);
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

        #region DELETE data from database (Donor Module)
        public bool Delete(donorBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "DELETE FROM tbl_donors WHERE donor_id=@donor_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@donor_id", u.donor_id);
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


        #region count donors
        public string countDonors(string blood_group)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            string donors = "0";


            try
            {
                String sql = "SELECT * FROM tbl_donors WHERE blood_group='"+blood_group+"'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                donors= dt.Rows.Count.ToString();

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            finally
            { 
                conn.Close(); 
            
            }


            return donors;

        }







        #endregion

        public DataTable Search(string keywords)
        {
            // create a connection to the data base.
            SqlConnection conn = new SqlConnection(myconnstrng);


            //create a new data table
            DataTable dt = new DataTable();



            // Code for searching Users

            try
            {
                String sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '%" + keywords + "%' OR blood_group LIKE  '"+keywords+"'    ";
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




    }
}

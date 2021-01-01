using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class UsersDatabase
    {
        // static string to connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        public bool loginCheck(Users Userobj)
        {
            // create boolean varaible set it to false and return it 
            bool isSuccessful = false;
            //connecting to database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to check login
                string sql = "select * from users where username= @username and password=@password and usertype=@usertype";
                //sql command to pass value 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", Userobj.username);
                cmd.Parameters.AddWithValue("@password", Userobj.password);
                cmd.Parameters.AddWithValue("@usertype", Userobj.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // Checking the rows in DataTable
                if (dt.Rows.Count > 0)
                {
                    //login sucessful
                    isSuccessful = true;
                }
                else
                {
                    //Login failed
                    isSuccessful = false;
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

            return isSuccessful;
        }

        #region Select Users Data from Database
        public DataTable Select()
        {
            //Static MEthod to connect with Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //TO hold the data from database 
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data From DAtabase
                String sql = "SELECT * FROM users";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting DAta from dAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using entityLayer;
using log4net;

namespace dataAccessLayer
{
    public class UserDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(UserDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";

        //get User by Username and Password
        public user getAuthenticatedUser(String username, String password)
        {
            user tempUser = new user();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            tempUser.Username = (String)rdr["username"];
                            tempUser.First_Name = (String)rdr["f_Name"];
                            tempUser.Last_Name = (String)rdr["l_Name"];
                            tempUser.Address = (String)rdr["address"];
                            tempUser.Telephone = (String)rdr["tel"];
                            tempUser.NIC = (String)rdr["nic"];
                            tempUser.Role = (String)rdr["role"];
                            tempUser.Password = (String)rdr["password"];
                        }
                    }
                    con.Close();

                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAuthenticatedUser: " + e.Message);
                //Console.WriteLine("DAL Error in getAuthenticatedUser: " + e.Message);
            }
            return tempUser;
        }

        public List<user> getAllUsers()
        {
            List<user> usrLst = new List<user>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            user tempUser = new user();
                            tempUser.Username = (String)rdr["username"];
                            tempUser.First_Name = (String)rdr["f_Name"];
                            tempUser.Last_Name = (String)rdr["l_Name"];
                            tempUser.Address = (String)rdr["address"];
                            tempUser.Telephone = (String)rdr["tel"];
                            tempUser.NIC = (String)rdr["nic"];
                            tempUser.Role = (String)rdr["role"];
                            tempUser.Password = (String)rdr["password"];
                            usrLst.Add(tempUser);
                        }
                    }
                    con.Close();

                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAllUsers: " + e.Message);
                //Console.WriteLine("DAL Error in getAllUsers: " + e.Message);
            }
            return usrLst;
        }

        public user getUsrByUsrname(String username)
        {
            user tempUser = new user();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SearchUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            if (!rdr[0].ToString().Equals("0"))
                            {
                                tempUser.Username = (String)rdr["username"];
                                tempUser.First_Name = (String)rdr["f_Name"];
                                tempUser.Last_Name = (String)rdr["l_Name"];
                                tempUser.Address = (String)rdr["address"];
                                tempUser.Telephone = (String)rdr["tel"];
                                tempUser.NIC = (String)rdr["nic"];
                                tempUser.Role = (String)rdr["role"];
                                tempUser.Password = (String)rdr["password"];
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getUsrByUsrname: " + e.Message);
                //Console.WriteLine("DAL Error in getUsrByUsrname: " + e.Message);
            }
            return tempUser;
        }



        public int insertUser(user tempUser)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", tempUser.Username);
                    cmd.Parameters.AddWithValue("@f_Name", tempUser.First_Name);
                    cmd.Parameters.AddWithValue("@l_Name", tempUser.Last_Name);
                    cmd.Parameters.AddWithValue("@address", tempUser.Address);
                    cmd.Parameters.AddWithValue("@tel", tempUser.Telephone);
                    cmd.Parameters.AddWithValue("@nic", tempUser.NIC);
                    cmd.Parameters.AddWithValue("@role", tempUser.Role);
                    cmd.Parameters.AddWithValue("@password", tempUser.Password);
                    result = (Int32)cmd.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in insertUser: " + e.Message);
                //Console.WriteLine("DAL Error in insertUser: " + e.Message);
            }
            return result;
        }

        public Boolean updateUser(user tempUser)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uName", tempUser.Username);
                    cmd.Parameters.AddWithValue("@fName", tempUser.First_Name);
                    cmd.Parameters.AddWithValue("@lName", tempUser.Last_Name);
                    cmd.Parameters.AddWithValue("@address", tempUser.Address);
                    cmd.Parameters.AddWithValue("@tel", tempUser.Telephone);
                    cmd.Parameters.AddWithValue("@nic", tempUser.NIC);
                    cmd.Parameters.AddWithValue("@role", tempUser.Role);
                    cmd.Parameters.AddWithValue("@pWord", tempUser.Password);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in insertUser: " + e.Message);
                //Console.WriteLine("DAL Error in insertUser: " + e.Message);
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

        public Boolean deleteUser(user tempUser)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("deleteUserByUName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uName", tempUser.Username);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in insertUser: " + e.Message);
                //Console.WriteLine("DAL Error in insertUser: " + e.Message);
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

    }
}

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
    public class CatagoryDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CatagoryDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";
        public int insertCatagory(itemCategory tempCat)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("InsertCatagory", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@prod_Cat_Id", tempCat.ItemCatID);
                    cmd.Parameters.AddWithValue("@prod_Cat_Name", tempCat.Item_Category_Name);
                    cmd.Parameters.AddWithValue("@prod_Cat_Description", tempCat.Item_Category_Description);
                    cmd.ExecuteScalar();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in insertCatagory: " + e.Message);
                //Console.WriteLine("DAL Error in insertCatagory: " + e.Message);
                result = 0;
            }
            return result;
        }

        public List<itemCategory> getAllCatagories()
        {
            List<itemCategory> catagoryLst = new List<itemCategory>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetALLCatagories", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            itemCategory tmpCat = new itemCategory();
                            tmpCat.Item_Category_ID = (int)rdr["prod_Cat_Id"];
                            tmpCat.Item_Category_Name = (String)rdr["prod_Cat_Name"];
                            tmpCat.Item_Category_Description = (String)rdr["prod_Cat_Description"];
                            catagoryLst.Add(tmpCat);
                        }
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAllCatagories: " + e.Message);
                //Console.WriteLine("DAL Error in getAllCatagories: " + e.Message);
            }
            return catagoryLst;
        }

        public itemCategory getCatByID(int prod_Cat_Id)
        {
            itemCategory tmpCat = new itemCategory();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetCatagoryById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_Cat_Id", prod_Cat_Id);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            if (!rdr[0].ToString().Equals("0"))
                            {
                                tmpCat.Item_Category_ID = (int)rdr["prod_Cat_Id"];
                                tmpCat.Item_Category_Name = (String)rdr["prod_Cat_Name"];
                                tmpCat.Item_Category_Description = (String)rdr["prod_Cat_Description"];
                            }
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getCatByID:" + e.ToString());
                //Console.WriteLine("DAL Error in getCatByID:" + e.ToString());
            }
            return tmpCat;
        }


        public Boolean DeleteCatagory(int prod_Cat_Id)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteCatByID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_Cat_Id", prod_Cat_Id);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in DeleteCatagory:" + e.ToString());
                //Console.WriteLine("DAL Error in DeleteCatagory:" + e.ToString());
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

    }
}

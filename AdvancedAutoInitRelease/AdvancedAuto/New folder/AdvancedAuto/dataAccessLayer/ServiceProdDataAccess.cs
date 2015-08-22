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
    public class ServiceProdDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(ServiceProdDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";
        public ServiceProdDataAccess() { }


        public int insertServiceProduct(serviceProducts tempService)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertServiceProd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@serv_ID", tempService.ServiceProID);
                    //cmd.Parameters.AddWithValue("@serv_Code", tempService.Service_Name);
                    cmd.Parameters.AddWithValue("@serv_Name", tempService.Service_Name);
                    //cmd.Parameters.AddWithValue("@serv_Description", tempService.Service_Desc);
                    cmd.Parameters.AddWithValue("@serv_Price", tempService.Service_Price);
                    cmd.Parameters.AddWithValue("@serv_Qty", tempService._qty);
                    result = (Int32)cmd.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in insertServiceProduct: " + e.Message);
                //Console.WriteLine("DAL Error in insertServiceProduct: " + e.Message);
            }
            return result;
        }

        public int insertServiceProductNgetID(serviceProducts tempService)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertServiceProd_N_GetID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@serv_ID", tempService.ServiceProID);
                    //cmd.Parameters.AddWithValue("@serv_Code", tempService.Service_Name);
                    cmd.Parameters.AddWithValue("@serv_Name", tempService.Service_Name);
                    //cmd.Parameters.AddWithValue("@serv_Description", tempService.Service_Desc);
                    cmd.Parameters.AddWithValue("@serv_Price", tempService.Service_Price);
                    cmd.Parameters.AddWithValue("@serv_Qty", tempService._qty);
                    decimal tmpresult = (decimal)cmd.ExecuteScalar();
                    result = Convert.ToInt32(tmpresult);
                    con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in ServiceProdDataAccess.insertServiceProductNgetID: " + e.Message);
                //Console.WriteLine("DAL Error in ServiceProdDataAccess.insertServiceProductNgetID: " + e.Message);
            }
            return result;
        }

        public List<serviceProducts> getAllServiceProducts()
        {
            List<serviceProducts> srvcProductLst = new List<serviceProducts>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetALLServiceProds", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            serviceProducts tmpSrvcProd = new serviceProducts();
                            tmpSrvcProd.Service_ID = (int)rdr["serv_ID"];
                            tmpSrvcProd.Service_Name = (String)rdr["serv_Name"];
                            //tmpSrvcProd.Service_Desc = (String)rdr["serv_Description"];
                            tmpSrvcProd.Service_Price = (Decimal)rdr["serv_Price"];
                            tmpSrvcProd._qty = (int)rdr["serv_Qty"];
                            srvcProductLst.Add(tmpSrvcProd);
                        }
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAllServiceProducts: " + e.Message);
                //Console.WriteLine("DAL Error in getAllServiceProducts: " + e.Message);
            }
            return srvcProductLst;
        }


        public Boolean DeleteServiceByID(int serv_ID)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteSrvcByID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serv_ID", serv_ID);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in DeleteServiceByID:" + e.ToString());
                //Console.WriteLine("DAL Error in DeleteServiceByID:" + e.ToString());
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

    }
}

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
    public class StockDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(StockDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";

        public int insertStock(stock tempStock)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertStock", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_ID", tempStock.Product_ID);
                    cmd.Parameters.AddWithValue("@prod_Name", tempStock.Product_Name);
                    cmd.Parameters.AddWithValue("@details", tempStock._details);
                    cmd.Parameters.AddWithValue("@init_Date", tempStock.StockInitiation_Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@quantity", tempStock.Quantity);
                    cmd.Parameters.AddWithValue("@cost", tempStock._Cost);
                    result = (Int32)cmd.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in insertStock: " + e.Message);
                //Console.WriteLine("DAL Error in insertStock: " + e.Message);
            }
            return result;
        }



        public List<stock> getAllStocks()
        {
            List<stock> stockLst = new List<stock>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetALLStocks", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            stock tmpStck = new stock();
                            tmpStck.Stock_ID = (int)rdr["stock_ID"];
                            tmpStck.Product_ID = (int)rdr["prod_ID"];
                            tmpStck.Product_Name = (String)rdr["prod_Name"];
                            tmpStck._details = (String)rdr["details"];
                            tmpStck.StockInitiation_Date = Convert.ToDateTime(rdr["init_Date"]);
                            tmpStck.Quantity = (int)rdr["quantity"];
                            tmpStck._Cost = (Decimal)rdr["cost"];
                            stockLst.Add(tmpStck);

                        }
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAllStocks: " + e.Message);
                //Console.WriteLine("DAL Error in getAllStocks: " + e.Message);
            }
            return stockLst;
        }


        public Boolean DeleteStockByID(int stock_ID)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteStockByID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stock_ID", stock_ID);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in DeleteStockByID:" + e.ToString());
                //Console.WriteLine("DAL Error in DeleteStockByID:" + e.ToString());
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }


    }
}

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
    public class BillingDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(BillingDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";
        public BillingDataAccess() { }


        public int insertBill(String customer_name, String customer_tel, String username, DateTime bill_date, decimal bill_total, String vehicle_no)
        {
            int result = 0;
            //The stored procedure defined here returns the custom_Pack_ID id of the inserted custom package
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("InsertBill", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customer_name", customer_name);
                    cmd.Parameters.AddWithValue("@customer_tel", customer_tel);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@bill_date", bill_date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@bill_total", bill_total);
                    cmd.Parameters.AddWithValue("@vehicle_no", vehicle_no);
                    decimal tmpresult = (decimal)cmd.ExecuteScalar();
                    result = Convert.ToInt32(tmpresult);
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("\n DAL Error in BillingDataAccess.insertBill: " + e.ToString());
                //Console.WriteLine("DAL Error in BillingDataAccess.insertBill: " + e.ToString());
            }
            return result;
        }

        public int insertProdSrvItem(billingItem tmpPrdBItm, int billID)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("InsertBillItm_Prod", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bill_Id", billID);
                    cmd.Parameters.AddWithValue("@prod_Id", tmpPrdBItm.Product.ProductID);
                    cmd.Parameters.AddWithValue("@quantity", tmpPrdBItm.Quantiy);
                    cmd.Parameters.AddWithValue("@itm_total", tmpPrdBItm.Total);
                    result = (int)cmd.ExecuteScalar();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("\n DAL Error in BillingDataAccess.insertProdSrvItem: " + e.ToString());
                //Console.WriteLine("DAL Error in BillingDataAccess.insertProdSrvItem: " + e.ToString());
            }
            return result;
        }

        public int insertSrvcSrvItem(billingItem tmpSrvcBItm, int billID, int Serv_Id)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("InsertBillItm_Srvc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bill_Id", billID);
                    cmd.Parameters.AddWithValue("@Serv_Id", Serv_Id);
                    cmd.Parameters.AddWithValue("@quantity", tmpSrvcBItm.Quantiy);
                    cmd.Parameters.AddWithValue("@itm_total", tmpSrvcBItm.Total);
                    result = (int)cmd.ExecuteScalar();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("\n DAL Error in BillingDataAccess.insertProdSrvItem: " + e.ToString());
                //Console.WriteLine("DAL Error in BillingDataAccess.insertProdSrvItem: " + e.ToString());
            }
            return result;
        }

        public List<bill> getBillByDate(DateTime strt_Date, DateTime end_Dte) 
        {
            //Console.WriteLine("Keyword in DAO: getProductByCode " + kywrd);
            List<bill> billLst = new List<bill>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetBillByDate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@strt_Date", strt_Date);
                    cmd.Parameters.AddWithValue("@end_Dte", end_Dte);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                bill tmpBill = new bill();
                                tmpBill.BillId = (int)rdr["bill_Id"];
                                tmpBill.CustomerName = (String)rdr["customer_name"];
                                tmpBill.CustomerTel = (String)rdr["customer_tel"];
                                tmpBill.UserName = (String)rdr["username"];
                                tmpBill.Date = Convert.ToDateTime(rdr["bill_date"]);
                                tmpBill.Total = Convert.ToDecimal(rdr["bill_total"]);
                                tmpBill.VehicleNo = (String)rdr["vehicle_no"];
                                billLst.Add(tmpBill);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("\n DAL Error in BillingDataAccess.getBillByDate: " + e.ToString());
                //Console.WriteLine("DAL Error in BillingDataAccess.getBillByDate: " + e.ToString());
            }
            return billLst;
        }

        public List<billingItem> getBillingItemData(int bill_Id) 
        {
            Console.WriteLine("Bill ID is: "+bill_Id);
            List<billingItem> billingLst = new List<billingItem>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetBillItemsWithData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bill_Id", bill_Id);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                billingItem tmpBillItm = new billingItem();
                                tmpBillItm.BillItemId = (int)rdr["bill_item_Id"];
                                tmpBillItm._type = (String)rdr["itmtype"];
                                tmpBillItm.Quantiy = (int)rdr["quantity"];
                                tmpBillItm.Total = Convert.ToDecimal(rdr["itm_total"]);

                                if (tmpBillItm._type.Equals("Product"))
                                {
                                    products tmpPrd = new products();
                                    tmpPrd.ProductID = (int)rdr["prod_ID"];
                                    tmpPrd.ProductCode = (String)rdr["prod_Code"];
                                    tmpPrd.ProductName = (String)rdr["prod_Name"];
                                    tmpPrd.ProductPrice = Convert.ToDecimal(rdr["prod_Price"]);
                                    tmpBillItm.Product = tmpPrd;
                                }
                                else if (tmpBillItm._type.Equals("Service")) 
                                {
                                    
                                    serviceProducts tmpSrvcPrd = new serviceProducts();
                                    tmpSrvcPrd.Service_ID = (int)rdr["Serv_Id"];
                                    Console.WriteLine("Service name id is: " + tmpSrvcPrd.Service_ID);
                                    tmpSrvcPrd.Service_Name = (String)rdr["serv_Name"];
                                    tmpSrvcPrd.Service_Price = Convert.ToDecimal(rdr["serv_Price"]);
                                    tmpBillItm.Service = tmpSrvcPrd;
                                }
                                billingLst.Add(tmpBillItm);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in BillingDataAccess.getBillingItemData: " + e.ToString());
                //Console.WriteLine("DAL Error in BillingDataAccess.getBillingItemData: " + e.ToString());
            }
            return billingLst;
        }
        //public int insertSrvcSrvItem(issueBill tmpPrdBItm, int billID)
        //{
        //    int result = 0;
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("InsertBillItm_Srvc", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@bill_Id", billID);
        //            cmd.Parameters.AddWithValue("@Serv_Id", tmpPrdBItm.id);
        //            cmd.Parameters.AddWithValue("@quantity", tmpPrdBItm.Quantity);
        //            cmd.Parameters.AddWithValue("@itm_total", tmpPrdBItm.Total);
        //            result = (int)cmd.ExecuteScalar();

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result = 0;
        //        logger.Error("DAL Error in insertSrvcSrvItem: " + e.ToString());
        //        //Console.WriteLine("DAL Error in insertSrvcSrvItem: " + e.ToString());
        //    }
        //    return result;
        //}



        //public int insertCstmPckSrvItem(issueBill tmpPrdBItm, int billID)
        //{
        //    int result = 0;
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("InsertBillItm_CstmPckage", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@bill_Id", billID);
        //            cmd.Parameters.AddWithValue("@custom_Pack_ID", tmpPrdBItm.id);
        //            cmd.Parameters.AddWithValue("@quantity", tmpPrdBItm.Quantity);
        //            cmd.Parameters.AddWithValue("@itm_total", tmpPrdBItm.Total);
        //            result = (int)cmd.ExecuteScalar();

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result = 0;
        //        logger.Error("DAL Error in insertCstmPckSrvItem: " + e.ToString());
        //        //Console.WriteLine("DAL Error in insertCstmPckSrvItem: " + e.ToString());
        //    }
        //    return result;
        //}

    }

}

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
    public class BillingItemDataAccess
    {


        //public billingItem getProdByCode(String prod_Code)
        //{
        //    billingItem tmpBillItem = new billingItem();
        //    products tmpProduct = new products();
        //    itemCategory tmpCategory = new itemCategory();

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("GetProductByCode", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@prod_Code", prod_Code);
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        tmpCategory.Item_Category_ID = Convert.ToInt32(rdr["prod_Cat_ID"]);
        //                        tmpCategory.Item_Category_Name = (String)rdr["prod_Cat_Name"];
        //                        tmpCategory.Item_Category_Description = (String)rdr["prod_Cat_Description"];

        //                        tmpProduct.ProductID = Convert.ToInt32(rdr["prod_ID"]);
        //                        tmpProduct.ProductCode = rdr["prod_Code"].ToString();
        //                        tmpProduct.ProductName = (String)rdr["prod_Name"];
        //                        tmpProduct.ProductMake = (String)rdr["prod_Make"];
        //                        tmpProduct.ProductModel = (String)rdr["prod_Model"];
        //                        tmpProduct.ProductDescription = (String)rdr["prod_Description"];
        //                        tmpProduct.ProductPrice = Convert.ToDecimal(rdr["prod_Price"]);
        //                        tmpProduct.ProductCateogery = tmpCategory;
        //                        tmpProduct.Quantity = Convert.ToInt32(rdr["quantity"]);
        //                    }
        //                }

        //            }

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        logger.Error("DAL Error in getProdByCode: " + e.ToString());
        //        //Console.WriteLine("DAL Error in getProdByCode: " + e.ToString());
        //    }

        //    tmpBillItem.BillItemId = 0;
        //    tmpBillItem.Service = null;
        //    tmpBillItem.Product = tmpProduct;
        //    tmpBillItem.Quantiy = 0;
        //    tmpBillItem.Total = 0;

        //    return tmpBillItem;
        //}


        //public List<issueBill> getCustPackByName(String Custom_Pack_Name)
        //{

        //    List<issueBill> issueBillLst = new List<issueBill>();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("GetCustPackByName", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@Custom_Pack_Name", Custom_Pack_Name);
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        issueBill tmpIssueBill = new issueBill();
        //                        tmpIssueBill.id = Convert.ToInt32(rdr["custom_Pack_ID"]);
        //                        //tmpIssueBill.Item_Code = rdr["Custom_Pack_Name"].ToString();
        //                        tmpIssueBill.Item_Name = (String)rdr["Custom_Pack_Name"];
        //                        tmpIssueBill.Price = Convert.ToDecimal(rdr["total"]);
        //                        tmpIssueBill.Total = tmpIssueBill.Price;
        //                        tmpIssueBill.Category = "CustomPackage";
        //                        issueBillLst.Add(tmpIssueBill);
        //                    }
        //                }

        //            }

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        logger.Error("DAL Error in getCustPackByName: " + e.ToString());
        //        //Console.WriteLine("DAL Error in getCustPackByName: " + e.ToString());
        //    }
        //    return issueBillLst;
        //}


        //public List<issueBill> getProdByName(String prod_Name)
        //{

        //    List<issueBill> issueBillLst = new List<issueBill>();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("GetProductByName", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@prod_Name", prod_Name);
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        issueBill tmpIssueBill = new issueBill();
        //                        tmpIssueBill.id = Convert.ToInt32(rdr["prod_ID"]);
        //                        tmpIssueBill.Item_Code = rdr["prod_Code"].ToString();
        //                        tmpIssueBill.Item_Name = (String)rdr["prod_Name"];
        //                        tmpIssueBill.Price = Convert.ToDecimal(rdr["prod_Price"]);
        //                        tmpIssueBill.Category = "Product";
        //                        issueBillLst.Add(tmpIssueBill);
        //                    }
        //                }

        //            }

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        logger.Error("DAL Error in getProdByName: " + e.ToString());
        //        //Console.WriteLine("DAL Error in getProdByName: " + e.ToString());
        //    }
        //    return issueBillLst;
        //}


        //public List<issueBill> getSrvcByName(String serv_Name)
        //{

        //    List<issueBill> issueBillLst = new List<issueBill>();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("GetServiceByName", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@serv_Name", serv_Name);
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        issueBill tmpIssueBill = new issueBill();
        //                        tmpIssueBill.id = Convert.ToInt32(rdr["serv_ID"]);
        //                        tmpIssueBill.Item_Code = rdr["serv_Code"].ToString();
        //                        tmpIssueBill.Item_Name = (String)rdr["serv_Name"];
        //                        tmpIssueBill.Price = Convert.ToDecimal(rdr["serv_Price"]);
        //                        tmpIssueBill.Category = "Service";
        //                        issueBillLst.Add(tmpIssueBill);
        //                    }
        //                }

        //            }

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        logger.Error("DAL Error in getSrvcByName: " + e.ToString());
        //        //Console.WriteLine("DAL Error in getSrvcByName: " + e.ToString());
        //    }
        //    return issueBillLst;
        //}


        //public issueBill getSrvcByCode(String serv_Code)
        //{
        //    issueBill tmpIssueBill = new issueBill();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conString))
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            SqlCommand cmd = new SqlCommand("GetSrvcByCode", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@serv_Code", serv_Code);
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        tmpIssueBill.id = Convert.ToInt32(rdr["serv_ID"]);
        //                        tmpIssueBill.Item_Code = rdr["serv_Code"].ToString();
        //                        tmpIssueBill.Item_Name = (String)rdr["serv_Name"];
        //                        tmpIssueBill.Price = Convert.ToDecimal(rdr["serv_Price"]);
        //                        tmpIssueBill.Category = "Service";
        //                    }
        //                }

        //            }

        //            if (con.State == ConnectionState.Open)
        //                con.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        logger.Error("DAL Error in getSrvcByCode: " + e.ToString());
        //        //Console.WriteLine("DAL Error in getSrvcByCode: " + e.ToString());
        //    }
        //    return tmpIssueBill;
        //}
    }
}

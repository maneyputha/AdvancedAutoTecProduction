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
    public class ProductDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(ProductDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";

        public ProductDataAccess() { }





        public List<products> getAllProducts()
        {
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetALLProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            products tmpProd = new products();
                            tmpProd.ProductID = (int)rdr["pId"];
                            tmpProd.ProductCode = (String)rdr["pCode"];
                            tmpProd.ProductName = (String)rdr["pName"];
                            tmpProd.ProductMake = (String)rdr["pMake"];
                            tmpProd.ProductModel = (String)rdr["pModel"];
                            tmpProd.ProductDescription = (String)rdr["pDsc"];
                            tmpProd.ProductPrice = (Decimal)rdr["pPrice"];
                            tmpProd.Quantity = (Int32)rdr["prdQty"];
                            itemCategory tmpItmCat = new itemCategory();
                            tmpItmCat.Item_Category_ID = (int)rdr["pcatID"];
                            tmpItmCat.Item_Category_Name = (String)rdr["pcatName"];
                            tmpItmCat.Item_Category_Description = (String)rdr["pcatDsc"];
                            tmpProd.ProductCateogery = tmpItmCat;
                            productLst.Add(tmpProd);

                        }
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getAllProducts: " + e.Message);
                //Console.WriteLine("DAL Error in getAllProducts: " + e.Message);
            }
            return productLst;
        }

        public List<products> getProductByName(String kywrd)
        {
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetProductByName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_Name", kywrd);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                products tmpProd = new products();
                                tmpProd.ProductID = (int)rdr["prod_ID"];
                                tmpProd.ProductCode = (String)rdr["prod_Code"];
                                tmpProd.ProductName = (String)rdr["prod_Name"];
                                tmpProd.ProductMake = (String)rdr["prod_Make"];
                                tmpProd.ProductModel = (String)rdr["prod_Model"];
                                tmpProd.ProductDescription = (String)rdr["prod_Description"];
                                tmpProd.ProductPrice = (Decimal)rdr["prod_Price"];
                                tmpProd.Quantity = (Int32)rdr["quantity"];
                                productLst.Add(tmpProd);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProductByName: " + e.ToString());
                //Console.WriteLine("DAL Error in getProductByName: " + e.ToString());
            }
            return productLst;
        }

        public List<products> getProductByCatagory(String kywrd)
        {
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetProductByCatData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kywrd", kywrd);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                products tmpProd = new products();
                                tmpProd.ProductID = (int)rdr["prod_ID"];
                                tmpProd.ProductCode = (String)rdr["prod_Code"];
                                tmpProd.ProductName = (String)rdr["prod_Name"];
                                tmpProd.ProductMake = (String)rdr["prod_Make"];
                                tmpProd.ProductModel = (String)rdr["prod_Model"];
                                tmpProd.ProductDescription = (String)rdr["prod_Description"];
                                tmpProd.ProductPrice = (Decimal)rdr["prod_Price"];
                                tmpProd.Quantity = (Int32)rdr["quantity"];
                                productLst.Add(tmpProd);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProductByCatagory: " + e.ToString());
                //Console.WriteLine("DAL Error in getProductByCatagory: " + e.ToString());
            }
            return productLst;
        }

        public List<products> getProductByCode(String kywrd)
        {
            //Console.WriteLine("Keyword in DAO: getProductByCode " + kywrd);
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetProductByCode", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_Code", kywrd);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                products tmpProd = new products();
                                tmpProd.ProductID = (int)rdr["prod_ID"];
                                tmpProd.ProductCode = (String)rdr["prod_Code"];
                                tmpProd.ProductName = (String)rdr["prod_Name"];
                                tmpProd.ProductMake = (String)rdr["prod_Make"];
                                tmpProd.ProductModel = (String)rdr["prod_Model"];
                                tmpProd.ProductDescription = (String)rdr["prod_Description"];
                                tmpProd.ProductPrice = (Decimal)rdr["prod_Price"];
                                tmpProd.Quantity = (Int32)rdr["quantity"];
                                Console.WriteLine(tmpProd.ProductID);
                                productLst.Add(tmpProd);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProductByCode: " + e.ToString());
                //Console.WriteLine("DAL Error in getProductByCode: " + e.ToString());
            }
            return productLst;
        }
        public List<products> getProductByAllProdData(String kywrd)
        {
            Console.WriteLine("Keyword in DAO: getProductByCatData " + kywrd);
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetProductByNmeCodeNDsc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kywrd", kywrd);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                products tmpProd = new products();
                                tmpProd.ProductID = (int)rdr["prod_ID"];
                                tmpProd.ProductCode = (String)rdr["prod_Code"];
                                tmpProd.ProductName = (String)rdr["prod_Name"];
                                tmpProd.ProductMake = (String)rdr["prod_Make"];
                                tmpProd.ProductModel = (String)rdr["prod_Model"];
                                tmpProd.ProductDescription = (String)rdr["prod_Description"];
                                tmpProd.ProductPrice = (Decimal)rdr["prod_Price"];
                                tmpProd.Quantity = (Int32)rdr["quantity"];
                                Console.WriteLine(tmpProd.ProductID);
                                productLst.Add(tmpProd);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProductByAllProdData: " + e.ToString());
                //Console.WriteLine("DAL Error in getProductByAllProdData: " + e.ToString());
            }
            return productLst;
        }
        public List<products> getProdByCodeNNme(String kywrd)
        {
            List<products> productLst = new List<products>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetProductByNameNCode", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kywrd", kywrd);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                products tmpProd = new products();
                                tmpProd.ProductID = (int)rdr["prod_ID"];
                                tmpProd.ProductCode = (String)rdr["prod_Code"];
                                tmpProd.ProductName = (String)rdr["prod_Name"];
                                tmpProd.ProductMake = (String)rdr["prod_Make"];
                                tmpProd.ProductModel = (String)rdr["prod_Model"];
                                tmpProd.ProductDescription = (String)rdr["prod_Description"];
                                tmpProd.ProductPrice = (Decimal)rdr["prod_Price"];
                                tmpProd.Quantity = (Int32)rdr["quantity"];
                                productLst.Add(tmpProd);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProdByCodeNmeDetais: " + e.ToString());
                //Console.WriteLine("DAL Error in getProdByCodeNmeDetais: " + e.ToString());
            }
            return productLst;
        }


        public int insertProduct(products tempProduct)
        {
            int result = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_Code", tempProduct.ProductCode);
                    cmd.Parameters.AddWithValue("@prod_Name", tempProduct.ProductName);
                    cmd.Parameters.AddWithValue("@prod_Make", tempProduct.ProductMake);
                    cmd.Parameters.AddWithValue("@prod_Model", tempProduct.ProductModel);
                    cmd.Parameters.AddWithValue("@prod_Description", tempProduct.ProductDescription);
                    cmd.Parameters.AddWithValue("@prod_Price", tempProduct.ProductPrice);
                    cmd.Parameters.AddWithValue("@prod_Cat_ID", tempProduct.ProductCateogery.Item_Category_ID);
                    cmd.Parameters.AddWithValue("@quantity", tempProduct.Quantity);
                    result = (Int32)cmd.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in insertProduct: " + e.Message);
                //Console.WriteLine("DAL Error in insertProduct: " + e.Message);
            }
            return result;
        }


        public Boolean DeleteProductByID(int prod_ID)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteProdByID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_ID", prod_ID);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in DeleteProductByID:" + e.ToString());
                //Console.WriteLine("DAL Error in DeleteProductByID:" + e.ToString());
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

        public int updateProdQty(int prod_ID, int quantity)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Modify_Prod_Qty", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prod_ID", prod_ID);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    result = (int)cmd.ExecuteScalar();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                result = 0;
                logger.Error("DAL Error in ProductDataAccess.updateProdQty: " + e.ToString());
                //Console.WriteLine("DAL Error in ProductDataAccess.updateProdQty: " + e.ToString());
            }
            return result;
        }

        public Boolean updateProduct(products tempProduct)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pID", tempProduct.ProductID);
                    cmd.Parameters.AddWithValue("@pCode", tempProduct.ProductCode);
                    cmd.Parameters.AddWithValue("@pName", tempProduct.ProductName);
                    cmd.Parameters.AddWithValue("@pMake", tempProduct.ProductMake);
                    cmd.Parameters.AddWithValue("@pModel", tempProduct.ProductModel);
                    cmd.Parameters.AddWithValue("@pDesc", tempProduct.ProductDescription);
                    cmd.Parameters.AddWithValue("@pPrice", tempProduct.ProductPrice);
                    cmd.Parameters.AddWithValue("@pCatID", tempProduct.ProductCateogery.Item_Category_ID);
                    cmd.Parameters.AddWithValue("@qty", tempProduct.Quantity);
                    result = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in insertProduct: " + e.Message);
                //Console.WriteLine("DAL Error in insertProduct: " + e.Message);
            }
            if (result.Equals(0))
                return false;
            else
                return true;
        }

    }
}

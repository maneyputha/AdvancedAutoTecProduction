using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entityLayer;
using dataAccessLayer;

namespace businessLayer
{
    public class stockDataManipulations
    {

        public Boolean addNewItemCat(itemCategory itemCat)
        {
            CatagoryDataAccess cda1 = new CatagoryDataAccess();
            int insertResult = cda1.insertCatagory(itemCat);
            if (insertResult.Equals(1))
                return true;
            else
                return false;
        }

        public Boolean addNewServiceProduct(serviceProducts service)
        {
            ServiceProdDataAccess spda1 = new ServiceProdDataAccess();
            int insertResult = spda1.insertServiceProductNgetID(service);
            Console.WriteLine("Insertion Result is: " + insertResult);
            if (insertResult.Equals(1))
                return true;
            else
                return false;
        }

        public List<itemCategory> getAllCategories()
        {
            CatagoryDataAccess cda1 = new CatagoryDataAccess();
            return cda1.getAllCatagories();
        }

        public Boolean addNewProduct(products category)
        {
            ProductDataAccess pda1 = new ProductDataAccess();
            int insertResult = pda1.insertProduct(category);
            if (insertResult.Equals(1))
                return true;
            else
                return false;
        }

        public List<products> getAllProducts()
        {
            ProductDataAccess pda1 = new ProductDataAccess();
            return pda1.getAllProducts();
        }

        public List<serviceProducts> getAllServices()
        {
            ServiceProdDataAccess spda1 = new ServiceProdDataAccess();
            return spda1.getAllServiceProducts();
        }

        public List<String> getAllProductCodeName(int type)
        {
            List<String> itemList = new List<string>();
            return itemList;
        }

        public List<String> getAllServiceCodeName(int type)
        {
            List<String> itemList = new List<string>();
            return itemList;
        }

        public List<String> getAllCustomCatCodeName(int type)
        {
            List<String> itemList = new List<string>();
            return itemList;
        }

        public List<products> searchNAddProds(String keyword, String srchType)
        {
            List<products> tmpPrds = new List<products>();
            if (srchType.Equals("Code"))
            {
                tmpPrds = new ProductDataAccess().getProductByCode(keyword);
                //Console.WriteLine(tmpPrds.ElementAt(0).ProductName);
            }
            else if (srchType.Equals("Name"))
            {
                tmpPrds = new ProductDataAccess().getProductByName(keyword);
            }
            else if (srchType.Equals("Catagory Details"))
            {
                tmpPrds = new ProductDataAccess().getProductByCatagory(keyword);
            }
            else if (srchType.Equals("All"))
            {
                tmpPrds = new ProductDataAccess().getProductByAllProdData(keyword);
            }
            return tmpPrds;
        }
        public Boolean issueBill(List<billingItem> billItemGrid, String customer_name, String customer_tel, String username, DateTime bill_date, decimal bill_total, String vehicle_no)
        {
            Boolean result = true;
            int billID = new BillingDataAccess().insertBill(customer_name, customer_tel, username, bill_date, bill_total, vehicle_no);
            if (billID > 0)
            {
                foreach (billingItem bi1 in billItemGrid)
                {
                    if (bi1._type.Equals("Product"))
                    {
                        int billingResult = new BillingDataAccess().insertProdSrvItem(bi1, billID);
                        if (billingResult > 0)
                        {
                            int modifiedQty = bi1.Product.Quantity - bi1.Quantiy;
                            if (modifiedQty >= 0)
                            {
                                new ProductDataAccess().updateProdQty(bi1.Product.ProductID, modifiedQty);
                            }
                            else
                            {
                                result = false;
                                //Console.WriteLine("BL WARNING in stockDataManipulations.issueBill: The modified quantity of the product: " + bi1.Product.ProductID + " is: " + modifiedQty);
                            }
                        }
                        else
                        { result = false; }
                    }
                    else if (bi1._type.Equals("Service"))
                    {
                        int srvcPrdID = new ServiceProdDataAccess().insertServiceProductNgetID(bi1.Service);

                        if (srvcPrdID > 0)
                        {
                            int billingResult = new BillingDataAccess().insertSrvcSrvItem(bi1, billID, srvcPrdID);
                        }
                        else
                        { result = false; }
                    }
                    else
                    { result = false; }
                }
            }
            else { result = false; }

            return result;
        }

        public List<billingItem> getBillItems(int billID) 
        {
            return new BillingDataAccess().getBillingItemData(billID);
        }
        //public List <issueBill> fillBillObject(String catType,String itmType, String srchValue,int quantity)
        //{
        //    List<issueBill> issueBillLst = new List<issueBill>();
        //    if (catType.Equals("Product") && itmType.Equals("Code"))
        //    {
        //        Console.WriteLine("inside get prod by Code");
        //        issueBill tmpIssueBill = new issueBill();
        //        IssueBillDataAccess ibda1 = new IssueBillDataAccess();
        //        tmpIssueBill = ibda1.getProdByCode(srchValue);
        //        tmpIssueBill.Quantity = quantity;
        //        tmpIssueBill.Total = tmpIssueBill.Price * quantity;
        //        issueBillLst.Add(tmpIssueBill);
        //    }
        //    else if (catType.Equals("Product") && itmType.Equals("Name"))
        //    {
        //        Console.WriteLine("inside get prod by name");
        //       issueBillLst = new IssueBillDataAccess().getProdByName(srchValue);
        //    }
        //    else if (catType.Equals("Service") && itmType.Equals("Code"))
        //    {
        //        Console.WriteLine("inside get srvc by code");
        //        issueBill tmpIssueBill = new issueBill();
        //        IssueBillDataAccess ibda1 = new IssueBillDataAccess();
        //        tmpIssueBill = ibda1.getSrvcByCode(srchValue);
        //        tmpIssueBill.Total = tmpIssueBill.Price;
        //        issueBillLst.Add(tmpIssueBill);
        //    }
        //    else if (catType.Equals("Service") && itmType.Equals("Name"))
        //    {
        //        Console.WriteLine("inside get Service by name");
        //        issueBillLst = new IssueBillDataAccess().getSrvcByName(srchValue);
        //    }
        //    else if (catType.Equals("Custom Bill"))
        //    {
        //        Console.WriteLine("inside get CustomBill by name");
        //        issueBillLst = new IssueBillDataAccess().getCustPackByName(srchValue);
        //    }
        //    return issueBillLst;
        //}

        //public Boolean billItem(String customer_name, String customer_tel, String username, DateTime bill_date, decimal bill_total,List<issueBill> billProducts)
        //{
        //    BillingDataAccess bda1 = new BillingDataAccess();
        //    int billID=bda1.insertBill(customer_name, customer_tel, username, bill_date, bill_total);
        //    Console.WriteLine("Bill ID is: " + billID);
        //    if (!billID.Equals(0)) 
        //    {
        //        foreach (issueBill tmpBill in billProducts)
        //        {
        //            if (tmpBill.Category.Equals("Product"))
        //            {
        //                BillingDataAccess bda2 = new BillingDataAccess();
        //                bda2.insertProdSrvItem(tmpBill,billID);
        //            }
        //            else if (tmpBill.Category.Equals("Service"))
        //            {
        //                BillingDataAccess bda2 = new BillingDataAccess();
        //                bda2.insertSrvcSrvItem(tmpBill, billID);
        //            }
        //            else if (tmpBill.Category.Equals("CstmPack"))
        //            {
        //                BillingDataAccess bda2 = new BillingDataAccess();
        //                bda2.insertCstmPckSrvItem(tmpBill, billID);
        //            }
        //        }
        //    }

        //    return true;
        //}

        public List<stock> getCurrentStockData()
        {
            //Console.WriteLine("inside current stockdata");
            List<stock> sdb1 = new StockDataAccess().getAllStocks();
            //Console.WriteLine("Databind size is: " + sdb1.Count);
            return sdb1;
        }

        public Boolean deleteStock(stock stockItem)
        {
            return new StockDataAccess().DeleteStockByID(stockItem.Stock_ID);
        }

        public Boolean deleteCategory(itemCategory catItem)
        {
            CatagoryDataAccess cda1 = new CatagoryDataAccess();
            return cda1.DeleteCatagory(catItem.Item_Category_ID);
        }

        public Boolean deleteProduct(products product)
        {
            ProductDataAccess pda1 = new ProductDataAccess();
            return pda1.DeleteProductByID(product.ProductID);
        }

        public Boolean deleteBill(bill bill)
        {
            return true;
        }

        public Boolean deleteService(serviceProducts service)
        {
            return new ServiceProdDataAccess().DeleteServiceByID(service.Service_ID);
        }

        public List<bill> generateSalesReportWithin(DateTime startDate, DateTime endDate)
        {
            return new SalesReportDataAccess().generateSalesReportWithin(startDate, endDate);
        }

        public List<products> getProdByCodeNNme(string srchKyWord)
        {
            return new ProductDataAccess().getProductByName(srchKyWord);
        }
        public List<products> getProdByCode(string srchKyWord)
        {
            return new ProductDataAccess().getProductByCode(srchKyWord);
        }

        public int addNewStocks(stock tmpStb)
        {
            return new StockDataAccess().insertStock(tmpStb);
        }
    }
}

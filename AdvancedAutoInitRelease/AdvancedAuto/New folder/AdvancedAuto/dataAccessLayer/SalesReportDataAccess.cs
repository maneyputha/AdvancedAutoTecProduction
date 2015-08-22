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
    public class SalesReportDataAccess
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SalesReportDataAccess));
        private String conString = "Data Source=.;Initial Catalog=Advanced_Auto_DB;Integrated Security=True";

        public SalesReportDataAccess() { }

        public List<bill> generateSalesReportWithin(DateTime startDate, DateTime endDate)
        {
            List<bill> salesReport = new List<bill>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("GetAllBillWithin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                bill bill = new bill();
                                bill.BillId = Convert.ToInt32(rdr["bill_Id"]);
                                bill.CustomerName = (String)rdr["customer_name"];
                                bill.CustomerTel = (String)rdr["customer_tel"];
                                bill.VehicleNo = (String)rdr["vehicle_no"];
                                bill.Date = (DateTime)rdr["bill_date"];
                                bill.UserName = (String)rdr["username"];
                                bill.BillItems = null;
                                bill.Total = Convert.ToDecimal(rdr["item_Total_Price"]);
                                salesReport.Add(bill);
                            }
                        }

                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception e)
            {
                logger.Error("DAL Error in getProdByCode: " + e.ToString());
                //Console.WriteLine("DAL Error in getProdByCode: " + e.ToString());
            }
            return salesReport;
        }


    }
}

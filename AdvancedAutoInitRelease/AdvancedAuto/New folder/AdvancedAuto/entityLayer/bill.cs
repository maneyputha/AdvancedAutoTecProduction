using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class bill
    {
        private int billId;
        private String customerName;
        private String customerTel;
        private String vehicleNo;
        private DateTime date;
        private String userName;
        private List<billingItem> billItems;
        private decimal total;

        public bill() { }

        public bill(int billId, String customerName, String customerTel, String vehicleNo, DateTime date,
            String userName, List<billingItem> billItems, decimal total)
        {
            this.billId = billId;
            this.customerName = customerName;
            this.customerTel = customerTel;
            this.vehicleNo = vehicleNo;
            this.date = date;
            this.userName = userName;
            this.billItems = billItems;
            this.total = total;
        }

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }

        public String CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public String CustomerTel
        {
            get { return customerTel; }
            set { customerTel = value; }
        }

        public String VehicleNo
        {
            get { return vehicleNo; }
            set { vehicleNo = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public List<billingItem> BillItems
        {
            get { return billItems; }
            set { billItems = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}

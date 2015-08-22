using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class serviceProducts
    {
        private int serviceProID;
        private String serviceProName;
        private int qty;
        private decimal serviceProPrice;
        public serviceProducts() { }

        public serviceProducts(int serviceProID, String serviceProName, int qty, decimal serviceProPrice)
        {
            this.serviceProID = serviceProID;
            this.serviceProName = serviceProName;
            this.qty = qty;
            this.serviceProPrice = serviceProPrice;
        }

        public int Service_ID
        {
            get { return serviceProID; }
            set { serviceProID = value; }
        }

        public String Service_Name
        {
            get { return serviceProName; }
            set { serviceProName = value; }
        }

        public int _qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public decimal Service_Price
        {
            get { return serviceProPrice; }
            set { serviceProPrice = value; }
        }
    }
}

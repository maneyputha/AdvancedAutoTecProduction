using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class stock
    {
        private int stockId;
        private int productId;
        private String productName;
        private String details;
        private DateTime stockInitiationDate;
        private int quantity;
        private decimal cost;

        public stock() { }

        public stock(int stockId, int productId, String productName, String details, DateTime stockInitiationDate, int quantity, decimal cost)
        {
            this.stockId = stockId;
            this.productId = productId;
            this.productName = productName;
            this.details = details;
            this.stockInitiationDate = stockInitiationDate;
            this.quantity = quantity;
            this.cost = cost;
        }

        public int Stock_ID
        {
            get { return stockId; }
            set { stockId = value; }
        }
        public int Product_ID
        {
            get { return productId; }
            set { productId = value; }
        }

        public String Product_Name
        {
            get { return productName; }
            set { productName = value; }
        }

        public String _details
        {
            get { return details; }
            set { details = value; }
        }

        public DateTime StockInitiation_Date
        {
            get { return stockInitiationDate; }
            set { stockInitiationDate = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal _Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}

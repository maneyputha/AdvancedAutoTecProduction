using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class billingItem
    {
        private int billItemId;
        private serviceProducts service;
        private products product;
        private int quantiy;
        private decimal total;
        private String type;

        public billingItem() { }

        public billingItem(int billItemId, serviceProducts service, products product
            , int quantiy, decimal total, String type)
        {
            this.billItemId = billItemId;
            this.service = service;
            this.product = product;
            this.quantiy = quantiy;
            this.total = total;
            this.type = type;
        }

        public int BillItemId
        {
            get { return billItemId; }
            set { billItemId = value; }
        }

        public serviceProducts Service
        {
            get { return service; }
            set { service = value; }
        }

        public products Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantiy
        {
            get { return quantiy; }
            set { quantiy = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public String _type
        {
            get { return type; }
            set { type = value; }
        }
    }
}

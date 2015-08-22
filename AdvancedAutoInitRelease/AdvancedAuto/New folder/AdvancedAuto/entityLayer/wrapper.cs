using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class wrapper
    {
        private user User;
        private serviceProducts service;
        private products product;
        private itemCategory category;
        private int flag;
        private int quantity;

        public user User1
        {
            get { return User; }
            set { User = value; }
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

        public itemCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}

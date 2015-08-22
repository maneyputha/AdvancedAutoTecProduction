using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class products
    {
        private int productID;
        private String productCode;
        private String productName;
        private String productMake;
        private String productModel;
        private String productDescription;
        private decimal productPrice;
        private itemCategory productCateogery;
        private int quantity;

        public products() { }

        public products(int productID, String productCode, String productName, String productMake, String productModel,
            String productDescription, decimal productPrice, itemCategory productCateogery, int quantity)
        {
            this.productID = productID;
            this.productCode = productCode;
            this.productName = productName;
            this.productMake = productMake;
            this.productModel = productModel;
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.productCateogery = productCateogery;
            this.quantity = quantity;
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public String ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public String ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public String ProductMake
        {
            get { return productMake; }
            set { productMake = value; }
        }

        public String ProductModel
        {
            get { return productModel; }
            set { productModel = value; }
        }

        public String ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public decimal ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public itemCategory ProductCateogery
        {
            get { return productCateogery; }
            set { productCateogery = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}

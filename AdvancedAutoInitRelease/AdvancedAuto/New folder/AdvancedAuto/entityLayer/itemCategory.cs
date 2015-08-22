using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class itemCategory
    {
        private int itemCatID;
        private String itemCategoryName;
        private String itemCategoryDesc;

        public itemCategory() { }

        public itemCategory(int itemCatID, String itemCategoryName, String itemCategoryDesc)
        {
            this.itemCatID = itemCatID;
            this.itemCategoryName = itemCategoryName;
            this.itemCategoryDesc = itemCategoryDesc;
        }

        public int Item_Category_ID
        {
            get { return itemCatID; }
            set { itemCatID = value; }
        }

        public String Item_Category_Name
        {
            get { return itemCategoryName; }
            set { itemCategoryName = value; }
        }

        public String Item_Category_Description
        {
            get { return itemCategoryDesc; }
            set { itemCategoryDesc = value; }
        }
    }
}

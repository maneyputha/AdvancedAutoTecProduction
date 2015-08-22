using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using entityLayer;
using businessLayer;
using log4net;

namespace uiLayer
{
    public partial class viewCateogery : Form
    {
        private BindingSource gridViewData;
        private static readonly ILog logger = LogManager.GetLogger(typeof(viewCateogery));

        public viewCateogery()
        {
            InitializeComponent();
            this.gridViewData = new BindingSource();
            bindDataTableData();
        }

        private void bindDataTableData()
        {
            stockDataManipulations stockDataManipulations = new stockDataManipulations();
            List<itemCategory> cateogeryList = stockDataManipulations.getAllCategories();
            categoryDataGrid.DataSource = cateogeryList;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (categoryDataGrid.RowCount != 0)
            {
                int selectedIndex = categoryDataGrid.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    string catId = categoryDataGrid.Rows[selectedIndex].Cells[0].Value.ToString();
                    string catName = categoryDataGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                    string catDesc = categoryDataGrid.Rows[selectedIndex].Cells[2].Value.ToString();

                    itemCategory selectedCategory = new itemCategory(int.Parse(catId), catName, catDesc);

                    stockDataManipulations stockDataManipulations = new stockDataManipulations();
                    Boolean categoryDeletion = stockDataManipulations.deleteCategory(selectedCategory);

                    if (categoryDeletion)
                    {
                        MessageBox.Show("Deletion Successfull. Data deleted successfully", "Important Note",
                        MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed. Error occured while deleting data", "Important Note",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
    }
}

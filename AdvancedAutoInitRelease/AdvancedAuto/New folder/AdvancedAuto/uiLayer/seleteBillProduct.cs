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

namespace uiLayer
{
    public partial class seleteBillProduct : Form
    {
        private MainMenuAdmin MainMenuAdmin;
        private int catType;
        private int itmType;

        public seleteBillProduct(MainMenuAdmin main, int catType, int itmType)
        {
            InitializeComponent();
            this.MainMenuAdmin = main;
            this.catType = catType;
            this.itmType = itmType;
        }

        private void retrieveDropDownValues()
        {
            stockDataManipulations stockDataManipulations = new stockDataManipulations();
            List<String> productValues = stockDataManipulations.getAllProductCodeName(itmType);
            bindDropDownValues(productValues);
            //if (catType == 1)
            //{
            //    List<String> custCatCodes = stockDataManipulations.getAllCustomCatCodeName(itmType);
            //    bindDropDownValues(custCatCodes);
            //}
            //else if (catType == 2)
            //{
            //    List<String> productValues = stockDataManipulations.getAllProductCodeName(itmType);
            //    bindDropDownValues(productValues);
            //}
            //else if (catType == 3)
            //{
            //    List<String> serviceValues = stockDataManipulations.getAllServiceCodeName(itmType);
            //    bindDropDownValues(serviceValues);
            //}
        }

        private void bindDropDownValues(List<String> values)
        {
            cmbValue.DataSource = new BindingSource(values, null);
            cmbValue.DisplayMember = "Value";
            cmbValue.ValueMember = "Key";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            String value = (String)cmbValue.SelectedItem;
            MainMenuAdmin.searchItemContext = value;
            MainMenuAdmin.bindSearchItemContext();
            this.Dispose();
        }
    }
}

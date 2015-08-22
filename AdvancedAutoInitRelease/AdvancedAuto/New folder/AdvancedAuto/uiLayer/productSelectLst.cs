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
    public partial class productSelectLst : Form
    {
        List<String> prdLst = new List<String>();
        public productSelectLst(List<String> prdLst)
        {
            this.prdLst = prdLst;
            lstBxSearchItms1.Items.Clear();
            foreach (String tmpPrd in prdLst)
            {
                lstBxSearchItms1.Items.Add(tmpPrd);
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //AddStock.prdIndex = lstBxSearchItms;
        }

        private void lstBxSearchItms1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

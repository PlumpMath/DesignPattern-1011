using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 商场管理软件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] {"正常收费","打八折","打七折","打五折"});
            cbxType.SelectedIndex = 0;
        }
        double total = 0.0d;

        private void btnOk_Click(object sender, EventArgs e)
        {
            CashContext ccontext = new CashContext(cbxType.SelectedItem.ToString());
            double totalPrices = 0.0d;
            totalPrices = ccontext.GetResult(Convert.ToDouble(txt_Price.Text) * Convert.ToDouble(txt_Num.Text));
            total = total + totalPrices;

            lbxList.Items.Add("单价："+txt_Price.Text+" 数量: "+txt_Num.Text+" 合计："+totalPrices.ToString());
            lblResult.Text = total.ToString();

        }
    }
}

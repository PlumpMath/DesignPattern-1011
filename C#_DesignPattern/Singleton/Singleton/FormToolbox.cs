using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Singleton
{
    public partial class FormToolbox : Form
    {
//        public FormToolbox()
//        {
//            InitializeComponent();
//        }

        private static FormToolbox ftb = null;

        private FormToolbox()
        {
            InitializeComponent();
        }



        public static FormToolbox GetInstance()
        {
            if (ftb == null || ftb.IsDisposed)
            {
                ftb = new FormToolbox();
                ftb.MdiParent = Form1.ActiveForm;
            }
            return ftb;
      
        }

        private void FormToolbox_Load(object sender, EventArgs e)
        {

        }
    }
}

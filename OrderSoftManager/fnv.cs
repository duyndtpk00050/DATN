using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSoftManager
{
    public partial class fnv : Form
    {
        public fnv()
        {
            InitializeComponent();
        }

        private void btnchamluongnv_Click(object sender, EventArgs e)
        {
            fchamluong frm = new fchamluong();
            frm.ShowDialog();
        }

        private void btnviewcv_Click(object sender, EventArgs e)
        {
            fcv frm = new fcv();
            frm.ShowDialog();
        }


    }
}

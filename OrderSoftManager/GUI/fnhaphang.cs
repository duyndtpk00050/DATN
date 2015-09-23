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
    public partial class fnhaphang : Form
    {
        public fnhaphang()
        {
            InitializeComponent();
        }

        private void btnaddmhnhap_Click(object sender, EventArgs e)
        {
            fmh frm = new fmh();
            frm.ShowDialog();
        }

        private void btnxuathdnhap_Click(object sender, EventArgs e)
        {
            fhdnhap frm = new fhdnhap();
            frm.ShowDialog();
        }

        private void btnviewncc_Click(object sender, EventArgs e)
        {
            fncc frm = new fncc();
            frm.ShowDialog();
        }
    }
}

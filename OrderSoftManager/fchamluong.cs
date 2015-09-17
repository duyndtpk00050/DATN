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
    public partial class fchamluong : Form
    {
        public fchamluong()
        {
            InitializeComponent();
        }

        private void btnviewcl_Click(object sender, EventArgs e)
        {
            fcl frm = new fcl();
            frm.ShowDialog();
        }

        private void btnbangluong_Click(object sender, EventArgs e)
        {
            fluong frm = new fluong();
            frm.ShowDialog();
        }

    }
}

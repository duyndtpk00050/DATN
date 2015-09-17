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
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void pbbanner_Click(object sender, EventArgs e)
        {
            fthongtin frm = new fthongtin();
            frm.Show();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            fdoimk frm = new fdoimk();
            frm.Show();
        }

        private void pbnhaphang_Click(object sender, EventArgs e)
        {
            fnhaphang frm = new fnhaphang();
            frm.Show();
        }

        private void pbbanhang_Click(object sender, EventArgs e)
        {
            fbanhang frm = new fbanhang();
            frm.Show();
        }

        private void pbthongke_Click(object sender, EventArgs e)
        {
            
        }

        private void pbphanquyen_Click(object sender, EventArgs e)
        {
            fphanquyen frm = new fphanquyen();
            frm.Show();
        }

        private void pbkhachhang_Click(object sender, EventArgs e)
        {
            fkh frm = new fkh();
            frm.Show();
        }

        private void pbnv_Click(object sender, EventArgs e)
        {
            fnv frm = new fnv();
            frm.Show();
        }

        private void pbmathang_Click(object sender, EventArgs e)
        {
            fmh frm = new fmh();
            frm.Show();
        }

        private void pbncc_Click(object sender, EventArgs e)
        {
            fncc frm = new fncc();
            frm.Show();
        }

    }
}

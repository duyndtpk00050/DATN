using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class fmh : Form
    {
        public fmh()
        {
            InitializeComponent();
        }
        
        private void btnloaimh_Click(object sender, EventArgs e)
        {
            floaimh frm = new floaimh();
            frm.ShowDialog();
        }

    }
}

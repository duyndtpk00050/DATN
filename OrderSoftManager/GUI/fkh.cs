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
    public partial class fkh : Form
    {
        public fkh()
        {
            InitializeComponent();
        }

        private void btnxemloaikh_Click(object sender, EventArgs e)
        {
            floaikh frm = new floaikh();
            frm.ShowDialog();
        }
    }
}

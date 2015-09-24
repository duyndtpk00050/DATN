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
    public partial class fbanhang : Form
    {
        public fbanhang()
        {
            InitializeComponent();
        }

        private void btndshdban_Click(object sender, EventArgs e)
        {
            fhdban frm = new fhdban();
            frm.ShowDialog();
        }

        private void btnaddkhhdban_Click(object sender, EventArgs e)
        {
            fkh frm = new fkh();
            frm.ShowDialog();
        }
    }
}

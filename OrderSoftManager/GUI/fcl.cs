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
    public partial class fcl : Form
    {
        public fcl()
        {
            InitializeComponent();
        }

        private void fcl_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void dataload()
        {
            BUS.calamBUS data = new BUS.calamBUS();
            dtgdscl.DataSource = data.showtable();
            for (int i = 0; i < dtgdscl.Rows.Count; i++)
            {
                dtgdscl.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}

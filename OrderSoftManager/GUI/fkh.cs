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

        BUS.khachhangBUS data = new BUS.khachhangBUS();
        DTO.khachhangDTO laygiatri = new DTO.khachhangDTO();

        private void fkh_Load(object sender, EventArgs e)
        {
            dataload();
        }
        private void dataload()
    {
        dtgdskh.DataSource = data.showtable();
        for (int i = 0; i < dtgdskh.Rows.Count; i++)
        {
           dtgdskh.Rows[i].Cells[0].Value = i + 1;
        }
    }
    }
}

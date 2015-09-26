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
    public partial class fhdnhap : Form
    {
        public fhdnhap()
        {
            InitializeComponent();
        }

        private void gbdshdnhap_Enter(object sender, EventArgs e)
        {

        }

        BUS.hoadonnhapBUS data = new BUS.hoadonnhapBUS();
        DTO.hoadonnhapDTO laygiatri = new DTO.hoadonnhapDTO();

        private void fhdnhap_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void dataload()
        {
            dtgdshdnhap.DataSource = data.showtable();

            for (int i = 0; i < dtgdshdnhap.Rows.Count; i++)
            {
                dtgdshdnhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dtgdshdnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

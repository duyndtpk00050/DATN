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

        private void fnhaphang_Load(object sender, EventArgs e)
        {
            dataload();
        }


        BUS.nhaphangBUS data = new BUS.nhaphangBUS();
        DTO.chitiethdnhapDTO laygiatri = new DTO.chitiethdnhapDTO();

        private void dataload()
        {
            // Đổ dữ liệu vào DataGridView
            dtgdschitiethdnhap.DataSource = data.showtable();
            // Số thứ tự tăng tự động
            for (int i = 0; i < dtgdschitiethdnhap.Rows.Count; i++)
            {
                dtgdschitiethdnhap.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}

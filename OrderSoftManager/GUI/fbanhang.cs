﻿using System;
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

        BUS.banhangBUS data = new BUS.banhangBUS();
        DTO.chitiethdbanDTO laygiatri = new DTO.chitiethdbanDTO();
        private void dataloadhd()
        {
            dtgchitiethdban.DataSource = data.showtablehd();
            for (int i = 0; i < dtgchitiethdban.Rows.Count; i++)
            {
                dtgchitiethdban.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void fbanhang_Load(object sender, EventArgs e)
        {
            dataloadhd();
            dataloadmh();
        }

        private void dataloadmh()
        {
            dtgdsmhhdban.DataSource = data.showtablemh();
            for (int i = 0; i < dtgdsmhhdban.Rows.Count; i++)
            {
                dtgdsmhhdban.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}

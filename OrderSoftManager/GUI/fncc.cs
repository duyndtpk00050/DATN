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
    public partial class fncc : Form
    {
        public fncc()
        {
            InitializeComponent();
        }

        private void fncc_Load(object sender, EventArgs e)
        {
            dataload();
        }
        private void dataload()
        {
            BUS.nhacungcapBUS data = new BUS.nhacungcapBUS();
            dtgdsncc.DataSource = data.showtable();

            for (int i = 0; i < dtgdsncc.Rows.Count; i++)
            {
                dtgdsncc.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnrefreshncc_Click(object sender, EventArgs e)
        {
            txttenncc.Clear();
            txtdiachincc.Clear();
            txtmailncc.Clear();
            txtsdtncc.Clear();
            txtfaxncc.Clear();
        }

        private void btnaddncc_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

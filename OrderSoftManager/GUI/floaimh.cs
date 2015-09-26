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
    public partial class floaimh : Form
    {
        public floaimh()
        {
            InitializeComponent();
        }
        BUS.loaimathangBUS data = new BUS.loaimathangBUS();
        DTO.loaimathangDTO laygiatri = new DTO.loaimathangDTO();
        private void dataload()
        {
            dtgdsloaimh.DataSource = data.showtable();
            for (int i = 0; i < dtgdsloaimh.Rows.Count; i++)
            {
                dtgdsloaimh.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void floaimh_Load(object sender, EventArgs e)
        {
            dataload();
        }

        public void addtable()
        {
            try
            {
                laygiatri.Tenloaimh = txttenloaimh.Text;
                data.addtable(laygiatri.Tenloaimh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clear()
        {
            txttenloaimh.Text = null;
        }

        private void btnaddloaimh_Click(object sender, EventArgs e)
        {
            addtable();
            dataload();
            clear();
        }
    }
}

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
    public partial class floaikh : Form
    {
        public floaikh()
        {
            InitializeComponent();
        }

        BUS.loaikhachhangBUS data = new BUS.loaikhachhangBUS();
        DTO.loaikhachhangDTO laygiatri = new DTO.loaikhachhangDTO();

        private void floaikh_Load(object sender, EventArgs e)
        {
            dataload();
        }
        private void dataload()
        {
            dtgdsloaikh.DataSource = data.showtable();
            for (int i = 0; i < dtgdsloaikh.Rows.Count; i++) 
            {
                dtgdsloaikh.Rows[i].Cells[0].Value = i + 1;
            }

        }
        public void addtable()
        {
            try
            {
                laygiatri.Tenloaikh = txttenloaikh.Text;
                data.addtable(laygiatri.Tenloaikh);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnaddloaikh_Click(object sender, EventArgs e)
        {
            addtable();
            dataload();
        }
    }
}

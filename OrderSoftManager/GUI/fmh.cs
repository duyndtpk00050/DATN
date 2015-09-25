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
    public partial class fmh : Form
    {
        public fmh()
        {
            InitializeComponent();
        }
        
        private void btnloaimh_Click(object sender, EventArgs e)
        {
            floaimh frm = new floaimh();
            frm.ShowDialog();
        }
        BUS.mathangBUS data = new BUS.mathangBUS();
        DTO.mathangDTO laygiatri = new DTO.mathangDTO(); 
        private void dataload()
        {
            dtgdsmh.DataSource = data.showtable();            
            for (int i = 0; i < dtgdsmh.Rows.Count; i++)
            {
                dtgdsmh.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void fmh_Load(object sender, EventArgs e)
        {
            dataload();
        }
        private void addtable()
        {
            try
            {
                laygiatri.Tenmh = txttenmh.Text;
                laygiatri.Idloaimh = cbbloaimh.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnaddmh_Click(object sender, EventArgs e)
        {
            addtable();
            dataload();
        }

    }
}

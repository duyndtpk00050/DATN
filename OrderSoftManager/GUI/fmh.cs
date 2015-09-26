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
            loadloaimh();
            dataload();

            
        }

        private void addtable()
        {
            try
            {
                laygiatri.Tenmh = txttenmh.Text;
                laygiatri.Idloaimh = Convert.ToInt16(cbbloaimh.ValueMember.ToString());
                laygiatri.Soluong = Convert.ToInt16(numsoluongmh.Value.ToString());
                laygiatri.Donvitinh = cbbdvtinhmh.SelectedText.ToString();
                laygiatri.Gianhap = Convert.ToDouble(numgianhapmh.Value.ToString());
                laygiatri.Giaban = Convert.ToDouble(numgiabanmh.Value.ToString());
                laygiatri.Thongtinmh = txtthongtinmh.Text;
                laygiatri.Anhmh = picmh.Image.ToString();

                data.addtable(laygiatri.Tenmh, laygiatri.Idloaimh, laygiatri.Soluong, laygiatri.Donvitinh, laygiatri.Gianhap, laygiatri.Giaban, laygiatri.Thongtinmh, laygiatri.Anhmh);
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

        private void loadloaimh()
        {

            cbbloaimh.DataSource = data.Showcbb();
            cbbloaimh.ValueMember = "idloaimh";
            cbbloaimh.DisplayMember = "tenloaimh";
        }

    }
}

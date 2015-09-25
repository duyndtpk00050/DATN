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
    public partial class fcv : Form
    {
        BUS.chucvuBUS data = new BUS.chucvuBUS();
        DTO.chucvuDTO laydulieu = new DTO.chucvuDTO();
        
        public fcv()
        {
            InitializeComponent();
        }
        
        private void fcv_Load(object sender, EventArgs e)
        {
            dataload();
        }

        public void dataload()
        {
            dtgdscv.DataSource = data.showtable();

            for (int i = 0; i < dtgdscv.Rows.Count - 1; i++)
            {
                dtgdscv.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void addtable()
        {
            laydulieu.Tencv = txttencv.Text;
            data.addtable(laydulieu.Tencv);

            dataload();
        }
        public void editrow()
        {
            laydulieu.Tencv = txttencv.Text;
            int columnid = Convert.ToInt16(dtgdscv.CurrentRow.Cells["idcv"].Value.ToString());
            data.editrow(columnid, laydulieu.Tencv);

            dataload();
        }
        public void delrows()
        {
            int columnid = Convert.ToInt16(dtgdscv.CurrentRow.Cells["idcv"].Value.ToString());
            data.delrows(columnid);

            dataload();
        }

        private void btnaddcv_Click(object sender, EventArgs e)
        {
            addtable();
        }

        private void btneditcv_Click(object sender, EventArgs e)
        {
            editrow();
        }

        private void btndelcv_Click(object sender, EventArgs e)
        {
            delrows();
        }
    }
}

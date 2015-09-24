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
    public partial class fcl : Form
    {
        public fcl()
        {
            InitializeComponent();
        }

        private void fcl_Load(object sender, EventArgs e)
        {
            dataload();
        }

        ///tạo đối tượng lấy các phương thức hoặc hàm từ Class calamBUS
        BUS.calamBUS data = new BUS.calamBUS();

        ///tạo đối tượng nhập các giá trị vào Class calamDTO
        DTO.calamDTO laygiatri = new DTO.calamDTO();

        /// <summary>
        /// hàm đổ dữ liệu vào DataGridView
        /// </summary>
        private void dataload()
        {
            ///đổ dữ liệu vào DataGridView
            dtgdscl.DataSource = data.showtable();

            ///Số thứ tự tăng tự động ở mỗi dòng thêm mới
            for (int i = 0; i < dtgdscl.Rows.Count; i++)
            {
                dtgdscl.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnaddcl_Click(object sender, EventArgs e)
        {
            addtable();
            dataload();
        }

        public void addtable()
        {
            try
            {
                laygiatri.Tencl = txttencl.Text;
                laygiatri.Thoigiancl = txtthoigianlam.Text;
                data.addtable(laygiatri.Tencl, laygiatri.Thoigiancl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

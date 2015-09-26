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

        // Tạo đối tượng lấy các phương thức hoặc hàm từ Class nhacungcapBUS
        BUS.nhacungcapBUS data = new BUS.nhacungcapBUS();

        // Tạo đối tượng nhập các giá trị vào Class nhacungcapDTO
        DTO.nhacungcapDTO laygiatri = new DTO.nhacungcapDTO();


        // Hàm đổ dữ liệu vào DataGridView
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
            //txttenncc.Clear();
            //txtdiachincc.Clear();
            //txtmailncc.Clear();
            //txtsdtncc.Clear();
            //txtfaxncc.Clear();
        }

        private void btnaddncc_Click(object sender, EventArgs e)
        {
            addtable();
            dataload();
        }


        // Hàm thêm dữ liệu vào Database
        private void addtable()
        {
            try
            {
                //lưu thông tin vào nhacungcapDTO
                laygiatri.Tenncc = txttenncc.Text;
                laygiatri.Diachincc = txtdiachincc.Text;
                laygiatri.Emailncc = txtmailncc.Text;
                laygiatri.Sofaxncc = Int16.Parse(txtfaxncc.Text);
                laygiatri.Sdtncc = Int16.Parse(txtsdtncc.Text);

                // Gán giá trị vào hàm truy vấn addtable chỉ thực thi từ Class nhacungcapBUS
                data.addtable(laygiatri.Tenncc, laygiatri.Diachincc, laygiatri.Emailncc, laygiatri.Sofaxncc, laygiatri.Sdtncc);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Hàm xóa dòng dữ liệu theo khóa chính của bảng trong Datatable
        private void btndelncc_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của cột có tên idncc tại dòng được chọn trong DataGridView
            int columnid = Convert.ToInt16(dtgdsncc.CurrentRow.Cells["idncc"].Value.ToString());

            // Thực thi hàm xóa có giá trị lấy được từ DataGridView
            data.delrows(columnid);

            // Load lại dữ liệu trong DataGridView
            dataload();
        }

        private void btneditncc_Click(object sender, EventArgs e)
        {
            int columnid = Convert.ToInt16(dtgdsncc.CurrentRow.Cells["idncc"].Value.ToString());

            laygiatri.Tenncc = txttenncc.Text;
            laygiatri.Diachincc = txtdiachincc.Text;
            laygiatri.Emailncc = txtmailncc.Text;
            laygiatri.Sofaxncc = Int16.Parse(txtfaxncc.Text);
            laygiatri.Sdtncc = Int16.Parse(txtsdtncc.Text);

            data.editrows(laygiatri.Tenncc, laygiatri.Diachincc, laygiatri.Emailncc, laygiatri.Sofaxncc, laygiatri.Sdtncc);

            dataload();
        }
    }
}

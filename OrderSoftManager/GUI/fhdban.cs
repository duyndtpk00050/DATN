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
    public partial class fhdban : Form
    {
        public fhdban()
        {
            InitializeComponent();
        }

        BUS.hoadonbanhangBUS data = new BUS.hoadonbanhangBUS();
        DTO.hoadonbanDTO laygiatri = new DTO.hoadonbanDTO();

        private void loadhdban()
        {
            dtgdshdban.DataSource = data.showtable();
            for (int i = 0; i < dtgdshdban.Rows.Count; i++)
            {
                dtgdshdban.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void fhdban_Load(object sender, EventArgs e)
        {
            loadhdban();
        }
    }
}

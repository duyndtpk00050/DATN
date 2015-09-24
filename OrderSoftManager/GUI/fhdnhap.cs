using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanHang
{
    public partial class fhdnhap : Form
    {
        SqlConnection conn;
        DataSet ds;
        DataView dv;
        DataTable dt;

        private void getdata()
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=DATN;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Select* from dbo.hoadonnhap";

            ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds.Tables["dbo.hoadonnhap"]);
            dtgdshdnhap.DataSource = dv;

        }
        public fhdnhap()
        {
            InitializeComponent();
        }

        private void gbdshdnhap_Enter(object sender, EventArgs e)
        {

        }

        private void fhdnhap_Load(object sender, EventArgs e)
        {

        }

        private void dtgdshdnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

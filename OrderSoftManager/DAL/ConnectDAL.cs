using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHang.DAL
{
    public class ConnectDAL
    {
        /// <summary>
        /// chuỗi kết nối đến CSDL
        /// </summary>
        public string str = " Data Source = (local); Database =PMQLKinhDoanhMayTinh; Integrated Security = True";


        /// <summary>
        /// hàm truy vấn Database
        /// </summary>
        /// <param name="caulenh">câu lệnh Select</param>
        /// <returns>bảng dữ liệu</returns>
        public DataTable laydulieu(string caulenh)
        {
            DataTable dt = null;
            try
            {
                ///khởi tạo lẹnh kết nối đên Database
                SqlConnection ketnoiden = new SqlConnection(str);

                ///mở kết nối
                ketnoiden.Open();


                ///thực hiện việc đọc dữ liệu từ Database
                SqlDataAdapter da = new SqlDataAdapter(caulenh, ketnoiden);

                ///dữ liệu đọc ra từ câu lệnh select được lưu vào 1 datatable trong dataset
                dt = new DataTable();

                ///đổ dữ liệu vào DataTable
                da.Fill(dt);

                ///đóng kết nối
                ketnoiden.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ///trả về một bảng chứa dữ liệu
            return dt;
        }
         
        /// <summary>
        /// hàm truy vấn Database
        /// </summary>
        /// <param name="caulenh">câu lệnh Update, Insert, Delete</param>
        /// <returns>kết quả thực thi</returns>
        public int thucthisql(string caulenh)
        {
            ///khởi tạo lẹnh kết nối đên Database
            SqlConnection ketnoiden = new SqlConnection(str);

            ///mở kết nối
            ketnoiden.Open();

            ///thực hiện việc đọc dữ liệu từ Database
            SqlCommand cmd = new SqlCommand(caulenh, ketnoiden);

            ///thực hiện việc ghi dữ liệu vào Database
            int ketqua = cmd.ExecuteNonQuery();

            ///trả về kết quả thực thi câu lệnh
            return ketqua;
        }

        
    }
}

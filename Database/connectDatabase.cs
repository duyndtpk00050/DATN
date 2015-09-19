using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class connectDatabase
    {
        private string str = "Data Source=(local);Initial Catalog=DATN;Integrated Security=True";
        private SqlCommand cmd = null;
        private SqlConnection conn = null;
        private SqlDataReader dr = null;

        public connectDatabase()
        {
            conn = new SqlConnection(str);
        }
        /// <summary>
        /// hàm để mở kết nối, nếu có lỗi xảy ra sẽ ném lỗi về Bussiness
        /// </summary>
        public void openConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// đóng kết nối
        /// </summary>
        public void closeConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// hàm cho phép tất cả các Bussiness lấy giá trị từ bảng bất kỳ
        /// </summary>
        /// <param name="table">tên bảng truyền vào từ Bussiness</param>
        /// <returns>trả về SqlDataReader</returns>
        public SqlDataReader getData(string table)
        {
            try
            {
                string sql = "select * from" + table;
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConn();
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dr;
        }
    }
}

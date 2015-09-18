﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class connectDatabase
    {
        private string str = "Data Source=VOSTRO2420;Initial Catalog=DATN;Integrated Security=True";
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
    }
}

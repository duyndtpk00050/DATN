﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang.DTO
{
    /// <summary>
    /// khai báo thuộc tính
    /// </summary>
    public class dangnhapDTO
    {
        private string _taikhoan;

        public string Taikhoan
        {
            get { return _taikhoan; }
            set { _taikhoan = value; }
        }
        private string _matkhau;

        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }

        /// <summary>
        /// phương thức làm trống
        /// </summary>
        public dangnhapDTO()
        {
            Taikhoan = null;
            Matkhau = null;
        }

        /// <summary>
        /// phương thức nhập liệu
        /// </summary>
        /// <param name="taikhoan">nhập tài khoản</param>
        /// <param name="matkhau">nhập mật khẩu</param>
        public dangnhapDTO(string taikhoan, string matkhau)
        {
            Taikhoan = taikhoan;
            Matkhau = matkhau;
        }
    }
}

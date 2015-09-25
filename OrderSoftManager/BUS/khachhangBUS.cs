using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class khachhangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        DTO.loaikhachhangDTO laythongtin = new DTO.loaikhachhangDTO();
        
        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select khachhang.hotenkh, khachhang.ngaysinhkh, khachhang.gioitinhkh, khachhang.cmndkh,khachhang.sdtkh, khachhang.diachikh, khachhang.emailkh, loaikhachhang.tenloaikh from khachhang join loaikhachhang on khachhang.idloaikh = loaikhachhang.idloaikh");
            return dt;
        }
    }
}

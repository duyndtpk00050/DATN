using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class hoadonbanhangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        DTO.hoadonbanDTO laythongtin = new DTO.hoadonbanDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select hoadonban.idhdban, hoadonban.ngayghihdban, khachhang.hotenkh, hoadonban.phivanchuyen, hoadonban.thueVAT, hoadonban.tongtienhdban, hoadonban.trangthai, nhanvien.tennv from hoadonban join khachhang on hoadonban.idkh = khachhang.idkh join nhanvien on nhanvien.idnv = hoadonban.idnv");

            return dt;
        }

    }
}

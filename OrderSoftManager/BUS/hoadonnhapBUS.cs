using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class hoadonnhapBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        DTO.hoadonnhapDTO laygiatri = new DTO.hoadonnhapDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select  hoadonnhap.idhdnhap,hoadonnhap.ngaynhap, nhacungcap.tenncc, hoadonnhap.phivanchuyen, hoadonnhap.thueVAT, hoadonnhap.tongtiennhap, nhanvien.tennv from hoadonnhap join nhacungcap on hoadonnhap.idncc = nhacungcap.idncc join nhanvien on nhanvien.idnv = hoadonnhap.idnv");
            return dt;
        }
    }
}

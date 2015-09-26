using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class nhaphangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        DTO.chitiethdnhapDTO laythongtin = new DTO.chitiethdnhapDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select hoadonnhap.idhdnhap, mathang.tenmh, chitiethdnhap.gianhap, chitiethdnhap.soluongnmhnhap, mathang.donvimh, chitiethdnhap.thanhtien, chitiethdnhap.trangthai, chitiethdnhap.tienno ,nhanvien.tennv, hoadonnhap.ngaynhap, nhacungcap.tenncc from chitiethdnhap join hoadonnhap on hoadonnhap.idhdnhap = chitiethdnhap.idhdnhap join nhanvien on nhanvien.idnv = hoadonnhap.idnv join nhacungcap on hoadonnhap.idncc = nhacungcap.idncc join mathang on mathang.idmh = chitiethdnhap.idmh");
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class banhangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();

        public DataTable showtablehd()
        {
            DataTable dt = ketnoi.laydulieu("select hoadonban.idhdban, mathang.tenmh, chitiethdban.soluongmhban, mathang.giaban, chitiethdban.thanhtien, mathang.donvimh from mathang join chitiethdban on mathang.idmh = chitiethdban.idmh join hoadonban on chitiethdban.idhdban = hoadonban.idhdban");
            return dt;
        }

        public DataTable showtablemh()
        {
            DataTable dt = ketnoi.laydulieu("select tenmh, soluong from mathang");
            return dt;
        }
    }
}

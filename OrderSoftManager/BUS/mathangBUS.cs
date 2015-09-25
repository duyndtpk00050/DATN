using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    public class mathangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        //DTO.mathangDTO laythongtin = new DTO.mathangDTO();
        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select mathang.tenmh, loaimathang.tenloaimh, mathang.soluong, mathang.donvimh, mathang.gianhap, mathang.giaban, mathang.thongtinmh, mathang.anhmh from mathang join loaimathang on mathang.idloaimh = loaimathang.idloaimh");
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class loaikhachhangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        DTO.loaikhachhangDTO laythongtin = new DTO.loaikhachhangDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select * from loaikhachhang");
            return dt ;
        }
        public void addtable(String tenloaikh)
        {
            ketnoi.thucthisql("insert into loaikhachhang(tenloaikh) values(N'"+ tenloaikh +"')");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    class loaimathangBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();
        
        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select *from loaimathang");
            return dt;
        }
    }
}

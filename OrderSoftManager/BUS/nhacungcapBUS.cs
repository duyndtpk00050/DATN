﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    public class nhacungcapBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select * from dbo.nhacungcap");
            return dt;
        }

        public void addtable(string tenncc, string diachincc, string emailncc, string sdtncc, string sofaxncc)
        {
            ketnoi.thucthisql("INSERT INTO nhacungcap values(N'" + tenncc + "',N'" + diachincc + "',N'" + emailncc + "',' + sofaxncc + ',' + sdtncc + ')");
        }
    }
}

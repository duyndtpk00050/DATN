using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    public class calamBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();

        DTO.calamDTO laythongtin = new DTO.calamDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("select * from calam");
            return dt;
        }

        public void addtable(string tenca, string thoigiancl)
        {
            ketnoi.thucthisql("insert into calam values(N'" + tenca + "',N'" + thoigiancl + "')");
        }

        public void delrows(int cacl)
        {
            ketnoi.thucthisql("delete from calam where idcl = " + cacl + "");
        }
    }
}

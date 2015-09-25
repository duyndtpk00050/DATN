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
            DataTable dt = ketnoi.laydulieu("SELECT * FROM calam");
            return dt;
        }

        public void addtable(string tenca, string thoigiancl)
        {
            ketnoi.thucthisql("INSERT INTO calam values(N'" + tenca + "',N'" + thoigiancl + "')");
        }

        public void delrows(int idcl)
        {
            ketnoi.thucthisql("DELETE FROM calam WHERE idcl = " + idcl + "");
        }

        public void editrows(int idcl, string tenca, string thoigiancl)
        {
            ketnoi.thucthisql("UPDATE calam SET tencl = N'" + tenca + "', thoigiancl = N'" + thoigiancl + "' WHERE idcl = '" + idcl + "'");
        }
    }
}

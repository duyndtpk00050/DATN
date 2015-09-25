using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanHang.BUS
{
    public class chucvuBUS
    {
        DAL.ConnectDAL ketnoi = new DAL.ConnectDAL();

        DTO.chucvuDTO laydulieu = new DTO.chucvuDTO();

        public DataTable showtable()
        {
            DataTable dt = ketnoi.laydulieu("SELECT * FROM chucvu");
            return dt;
        }

        public void addtable(string tencv)
        {
            ketnoi.thucthisql("INSERT INTO chucvu VALUES (N'" + tencv + "')");
        }

        public void delrows(int idcv)
        {
            ketnoi.thucthisql("DELETE FROM chucvu WHERE idcv =" + idcv + " ");
        }

        public void editrow(int idcv, string tencv)
        {
            ketnoi.thucthisql("UPDATE chucvu SET tencv = N'" + tencv + "' WHERE idcv =" + idcv + "");
        }
    }
}

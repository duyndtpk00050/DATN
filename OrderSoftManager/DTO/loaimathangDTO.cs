using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang.DTO
{
    public class loaimathangDTO
    {
        private int _idloaimh;

        public int Idloaimh
        {
            get { return _idloaimh; }
            set { _idloaimh = value; }
        }
        private string _tenloaimh;

        public string Tenloaimh
        {
            get { return _tenloaimh; }
            set { _tenloaimh = value; }
        }
    }
}

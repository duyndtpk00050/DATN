using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang
{
    public class chucvuDTO
    {
        private int _idcv;

        public int Idcv
        {
            get { return _idcv; }
            set { _idcv = value; }
        }
        private string _tencv;

        public string Tencv
        {
            get { return _tencv; }
            set { _tencv = value; }
        }
    }
}

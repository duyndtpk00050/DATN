using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class calamDTO
    {
        private int _idcl;

        public int Idcl
        {
            get { return _idcl; }
            set { _idcl = value; }
        }
        private string _tencl;

        public string Tencl
        {
            get { return _tencl; }
            set { _tencl = value; }
        }
        private string _thoigiancl;

        public string Thoigiancl
        {
            get { return _thoigiancl; }
            set { _thoigiancl = value; }
        }

        public calamDTO()
        {
            Tencl = null;
            Thoigiancl = null;
        }
        public calamDTO(string tencl, string thoigiancl)
        {
            Tencl = tencl;
            Thoigiancl = thoigiancl;
        }
    }
}

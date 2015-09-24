using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang
{
    public class chitietcalamDTO
    {
        private int _idchitietcl;

        public int Idchitietcl
        {
            get { return _idchitietcl; }
            set { _idchitietcl = value; }
        }
        private int _idcl;

        public int Idcl
        {
            get { return _idcl; }
            set { _idcl = value; }
        }
        private int _idnv;

        public int Idnv
        {
            get { return _idnv; }
            set { _idnv = value; }
        }
        private int _ngaylam;

        public int Ngaylam
        {
            get { return _ngaylam; }
            set { _ngaylam = value; }
        }
        private int _ngaytanngcl;

        public int Ngaytanngcl
        {
            get { return _ngaytanngcl; }
            set { _ngaytanngcl = value; }
        }
    }
}

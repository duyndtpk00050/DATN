using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class hoadonban
    {
        private int _idhdban;

        public int Idhdban
        {
            get { return _idhdban; }
            set { _idhdban = value; }
        }
        private DateTime _ngayghihdban;

        public DateTime Ngayghihdban
        {
            get { return _ngayghihdban; }
            set { _ngayghihdban = value; }
        }
        private double _phivanchuyen;

        public double Phivanchuyen
        {
            get { return _phivanchuyen; }
            set { _phivanchuyen = value; }
        }
        private double _tongtien;

        public double Tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        private int _idkh;

        public int Idkh
        {
            get { return _idkh; }
            set { _idkh = value; }
        }
        private int _idnv;

        public int Idnv
        {
            get { return _idnv; }
            set { _idnv = value; }
        }
    }
}

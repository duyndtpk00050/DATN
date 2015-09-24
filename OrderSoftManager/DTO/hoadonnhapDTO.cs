using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang
{
    public class hoadonnhapDTO
    {
        private int _idhdnhap;

        public int Idhdnhap
        {
            get { return _idhdnhap; }
            set { _idhdnhap = value; }
        }
        private DateTime _ngaynhap;

        public DateTime Ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }
        private double _phivanchuyen;

        public double Phivanchuyen
        {
            get { return _phivanchuyen; }
            set { _phivanchuyen = value; }
        }
        private double _tongtiennhap;

        public double Tongtiennhap
        {
            get { return _tongtiennhap; }
            set { _tongtiennhap = value; }
        }
        private int _idnv;

        public int Idnv
        {
            get { return _idnv; }
            set { _idnv = value; }
        }
        private int _idncc;

        public int Idncc
        {
            get { return _idncc; }
            set { _idncc = value; }
        }
    }
}

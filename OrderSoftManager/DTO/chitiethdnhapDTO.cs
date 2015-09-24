using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang
{
    public class chitiethdnhapDTO
    {
        private int _idchititethdnhap;

        public int Idchititethdnhap
        {
            get { return _idchititethdnhap; }
            set { _idchititethdnhap = value; }
        }
        private int _idhdnhap;

        public int Idhdnhap
        {
            get { return _idhdnhap; }
            set { _idhdnhap = value; }
        }
        private int _idmh;

        public int Idmh
        {
            get { return _idmh; }
            set { _idmh = value; }
        }
        private int _soluongnhap;

        public int Soluongnhap
        {
            get { return _soluongnhap; }
            set { _soluongnhap = value; }
        }
        private double _thanhtien;

        public double Thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
        private string _trangthai;

        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}

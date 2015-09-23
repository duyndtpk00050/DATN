using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class chitiethdbanLibrary
    {
        private int _idchitiethdban;

        public int Idchitiethdban
        {
            get { return _idchitiethdban; }
            set { _idchitiethdban = value; }
        }
        private int _idhdban;

        public int Idhdban
        {
            get { return _idhdban; }
            set { _idhdban = value; }
        }
        private int _idmh;

        public int Idmh
        {
            get { return _idmh; }
            set { _idmh = value; }
        }
        private double _soluongmhban;

        public double Soluongmhban
        {
            get { return _soluongmhban; }
            set { _soluongmhban = value; }
        }
        private double _thanhtien;

        public double Thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
        private string _phuongthucthanhtoan;

        public string Phuongthucthanhtoan
        {
            get { return _phuongthucthanhtoan; }
            set { _phuongthucthanhtoan = value; }
        }
        private string _trangthai;

        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}

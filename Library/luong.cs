using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class luong
    {
        private int _idluong;

        public int Idluong
        {
            get { return _idluong; }
            set { _idluong = value; }
        }
        private int _idnv;

        public int Idnv
        {
            get { return _idnv; }
            set { _idnv = value; }
        }
        private DateTime _ngaylamdau;

        public DateTime Ngaylamdau
        {
            get { return _ngaylamdau; }
            set { _ngaylamdau = value; }
        }
        private DateTime _ngaylamcuoi;

        public DateTime Ngaylamcuoi
        {
            get { return _ngaylamcuoi; }
            set { _ngaylamcuoi = value; }
        }
        private double _luongtangcl;

        public double Luongtangcl
        {
            get { return _luongtangcl; }
            set { _luongtangcl = value; }
        }
        private double _tongluong;

        public double Tongluong
        {
            get { return _tongluong; }
            set { _tongluong = value; }
        }
        private DateTime _ngaytraluong;

        public DateTime Ngaytraluong
        {
            get { return _ngaytraluong; }
            set { _ngaytraluong = value; }
        }
        private string _trangthainhanluong;

        public string Trangthainhanluong
        {
            get { return _trangthainhanluong; }
            set { _trangthainhanluong = value; }
        }
        private string _nvchamluong;

        public string Nvchamluong
        {
            get { return _nvchamluong; }
            set { _nvchamluong = value; }
        }
    }
}

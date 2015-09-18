using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class loaikhachhangLibrary
    {
        private int _idloaikh;

        public int Idloaikh
        {
            get { return _idloaikh; }
            set { _idloaikh = value; }
        }
        private string _tenloaikh;

        public string Tenloaikh
        {
            get { return _tenloaikh; }
            set { _tenloaikh = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHang
{
    public class khachhangDTO
    {
        private int _idkh;

        public int Idkh
        {
            get { return _idkh; }
            set { _idkh = value; }
        }
        private string _hotenkh;

        public string Hotenkh
        {
            get { return _hotenkh; }
            set { _hotenkh = value; }
        }
        private DateTime _ngaysinhkh;

        public DateTime Ngaysinhkh
        {
            get { return _ngaysinhkh; }
            set { _ngaysinhkh = value; }
        }
        private bool _gioitinhkh;

        public bool Gioitinhkh
        {
            get { return _gioitinhkh; }
            set { _gioitinhkh = value; }
        }
        private int _cmndkh;

        public int Cmndkh
        {
            get { return _cmndkh; }
            set { _cmndkh = value; }
        }
        private int _sdtkh;

        public int Sdtkh
        {
            get { return _sdtkh; }
            set { _sdtkh = value; }
        }
        private string _diachikh;

        public string Diachikh
        {
            get { return _diachikh; }
            set { _diachikh = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _idloaikh;

        public int Idloaikh
        {
            get { return _idloaikh; }
            set { _idloaikh = value; }
        }
    }
}

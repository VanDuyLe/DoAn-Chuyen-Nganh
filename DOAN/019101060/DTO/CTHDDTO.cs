using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class CTHDDTO
    {
        private string _mahd;
        private string _masanpham;
        private string _soluong;
        private string _gia;

        public string mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string masanpham
        {
            get { return _masanpham; }
            set { _masanpham = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public CTHDDTO()
        {
            _mahd = "";
            _masanpham = "";
            _soluong = "";
            _gia = "";
        }
        public CTHDDTO(string MaHD, string MaSP, string SoLuong, string Gia)
        {
            _mahd = MaHD;
            _masanpham = MaSP;
            _soluong = SoLuong;
            _gia = Gia;
        }
    }
}

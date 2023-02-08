using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class SanPhamDTO
    {
        private string _masp;
        private string _tensp;
        private string _gia;
        private string _soluong;
        private string _hangsx;
        private string _madanhmuc;
        public string masp
        {
            get { return _masp; }
            set { _masp = value; }
        }
        public string tensp
        {
            get { return _tensp; }
            set { _tensp = value; }
        }
        public string gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string hangsx
        {
            get { return _hangsx; }
            set { _hangsx = value; }
        }
        public string madanhmuc
        {
            get { return _madanhmuc; }
            set { _madanhmuc = value; }
        }
        public SanPhamDTO()
        {
            _masp = "";
            _tensp = "";
            _gia = "";
            _soluong = "";
            _hangsx = "";
            _madanhmuc = "";
        }
        public SanPhamDTO(string MaSanPham, string TenSanPham, string Gia, string SoLuong, string HangSanXuat, string MaDanhMuc)
        {
            _masp = MaSanPham;
            _tensp = TenSanPham;
            _gia = Gia;
            _soluong = SoLuong;
            _hangsx = HangSanXuat;
            _madanhmuc = MaDanhMuc;
        }
    }
}

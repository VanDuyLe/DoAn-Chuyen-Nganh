using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class HoaDonDTO
    {
        private string _mahd;
        private string _ngaylaphd;
        private string _manhanvien;
        private string _makhachhang;

        public string mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string ngaylaphd
        {
            get { return _ngaylaphd; }
            set { _ngaylaphd = value; }
        }
        public string manhanvien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }
        public string makhachhang
        {
            get { return _makhachhang; }
            set { _makhachhang = value; }
        }
        public HoaDonDTO()
        {
            _mahd = "";
            _ngaylaphd = "";
            _manhanvien = "";
            _makhachhang = "";
        }
        public HoaDonDTO(string MaHD, string NgayLapHD, string MaNhanVien, string MAKH)
        {
            _mahd = MaHD;
            _ngaylaphd = NgayLapHD;
            _manhanvien = MaNhanVien;
            _makhachhang = MAKH;
        }
    }
}

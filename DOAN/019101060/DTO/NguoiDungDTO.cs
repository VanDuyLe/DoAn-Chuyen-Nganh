using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class NguoiDungDTO
    {
        private string _taikhoan;
        private string _matkhau;
        private string _manhanvien;
        private string _machucvu;

        public string taikhoan
        {
            get { return _taikhoan; }
            set { _taikhoan = value; }
        }
        public string matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public string manhanvien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }
        public string machucvu
        {
            get { return _machucvu; }
            set { _machucvu = value; }
        }
        public NguoiDungDTO()
        {
            _taikhoan = "";
            _matkhau = "";
            _manhanvien = "";
            _machucvu = "";
        }
        public NguoiDungDTO(string TenTaiKhoan, string MatKhau, string MaNhanVien, string MaChucVu)
        {
            _taikhoan = TenTaiKhoan;
            _matkhau = MatKhau;
            _manhanvien = MaNhanVien;
            _machucvu = MaChucVu;
        }
    }
}

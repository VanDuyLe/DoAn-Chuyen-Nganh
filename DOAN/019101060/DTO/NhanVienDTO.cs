using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class NhanVienDTO
    {
        private string _manhanvien;
        private string _hoten;
        private string _diachi;
        private string _ngaysinh;
        private string _gioitinh;
        private string _dienthoai;
        private string _machucvu;
        public string manhanvien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        public string machucvu
        {
            get { return _machucvu; }
            set { _machucvu = value; }
        }
        public NhanVienDTO()
        {
            _manhanvien = "";
            _hoten = "";
            _diachi = "";
            _ngaysinh = "";
            _gioitinh = "";
            _dienthoai = "";
            _machucvu = "";
        }
        public NhanVienDTO(string MaNhanVien, string HoTen, string DiaChi, string NgaySinh, string GioiTinh, string DienThoai, string MaBangCap, string MaBoPhan, string MaChucVu)
        {
            _manhanvien = MaNhanVien;
            _hoten = HoTen;
            _diachi = DiaChi;
            _ngaysinh = NgaySinh;
            _gioitinh = GioiTinh;
            _dienthoai = DienThoai;
            _machucvu = MaChucVu;
        }
    }
}

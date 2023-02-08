using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class KhachHangDTO
    {
        private string _makh;
        private string _tenkh;
        private string _diachikh;
        private string _gioitinh;
        private string _dienthoai;
        private string _ngaysinh;
        private string _manv;

        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string tenkh
        {
            get { return _tenkh; }
            set { _tenkh = value; }
        }
        public string diachikh
        {
            get { return _diachikh; }
            set { _diachikh = value; }
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
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }

        public KhachHangDTO()
        {
            _makh = "";
            _tenkh = "";
            _diachikh = "";
            _gioitinh = "";
            _dienthoai = "";
            _ngaysinh = "";
            _manv = "";
        }
        public KhachHangDTO(string MaKhachHang, string TenKhachHang, string DiaChiKH, string GioiTinh, string SoDienThoai, string NgaySinh, string MaNhanVien)
        {
            _makh = MaKhachHang;
            _tenkh = TenKhachHang;
            _diachikh = DiaChiKH;
            _gioitinh = GioiTinh;
            _dienthoai = SoDienThoai;
            _ngaysinh = NgaySinh;
            _manv = MaNhanVien;
        }
    }
}

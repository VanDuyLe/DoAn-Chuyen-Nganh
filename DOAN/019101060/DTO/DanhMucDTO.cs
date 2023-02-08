using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class DanhMucDTO
    {
        private string _madanhmuc;
        private string _tendanhmuc;
        public string madanhmuc
        {
            get { return _madanhmuc; }
            set { _madanhmuc = value; }
        }
        public string tendanhmuc
        {
            get { return _tendanhmuc; }
            set { _tendanhmuc = value; }
        }
        public DanhMucDTO()
        {
            _madanhmuc = "";
            _tendanhmuc = "";
        }
        public DanhMucDTO(string MaDanhMuc, string TenDanhMuc)
        {
            _madanhmuc = MaDanhMuc;
            _tendanhmuc = TenDanhMuc;
        }
    }
}

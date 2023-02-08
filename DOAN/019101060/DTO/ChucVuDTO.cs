using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019101060.DTO
{
    class ChucVuDTO
    {
        private string _machucvu;
        private string _tenchucvu;
        public string machucvu
        {
            get { return _machucvu; }
            set { _machucvu = value; }
        }
        public string tenchucvu
        {
            get { return _tenchucvu; }
            set { _tenchucvu = value; }
        }
        public ChucVuDTO()
        {
            _machucvu = "";
            _tenchucvu = "";
        }
        public ChucVuDTO(string MaChucVu, string TenChucVu)
        {
            _machucvu = MaChucVu;
            _tenchucvu = TenChucVu;
        }
    }
}

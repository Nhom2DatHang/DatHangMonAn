using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatHangMonAn.DTO
{
    public class DTO_KhachHang
    {
        string maKH, tenKH, diaChiKH, sdtKH, email;
        int cMND;

        public int CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string DiaChiKH
        {
            get { return diaChiKH; }
            set { diaChiKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string SoDienThoai
        {
            get { return sdtKH; }
            set { sdtKH = value; }
        }

    }
}

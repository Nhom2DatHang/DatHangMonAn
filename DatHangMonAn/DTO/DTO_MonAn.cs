using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatHangMonAn.DTO
{
    public class DTO_MonAn
    {
        string maMonAn, tenMonAn, hinhAnh, DVT;
        int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string DVT1
        {
            get { return DVT; }
            set { DVT = value; }
        }

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        
        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        public string MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }
        
    }
}

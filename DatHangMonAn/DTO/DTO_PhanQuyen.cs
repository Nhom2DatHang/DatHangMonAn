using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatHangMonAn.DTO
{
    public class DTO_PhanQuyen
    {
        string maChucNang, maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }

        public string MaChucNang
        {
            get { return maChucNang; }
            set { maChucNang = value; }
        }
        int giaTriQuyen;

        public int GiaTriQuyen
        {
            get { return giaTriQuyen; }
            set { giaTriQuyen = value; }
        }
    }
}

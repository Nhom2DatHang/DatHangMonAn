
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatHangMonAn.DTO;
using System.Data.SqlClient;


namespace DatHangMonAn.Bussiness
{
   public class BLL_KhachHang
    {
        cls_DataLayer data;
        public BLL_KhachHang(string path)
        {
            data = new cls_DataLayer(path);
        }
        public object GetValue(ref string err)
        
        {
            return data.GetValue(ref err, "sp_KhachHang_SelectIDMax", CommandType.StoredProcedure, null);
        }
        public DataTable LayDanhSachKhachHang(ref string err)
        {
            return data.GetDataTable(ref err, "sp_KhachHang_Chon", CommandType.StoredProcedure, null);
        }
        public bool XoaThongTinKhachHang(ref string err, DTO_KhachHang _khachHang)
        {
            return data.MyExcuteNonQuery(ref err, "sp_KhachHang_Xoa", CommandType.StoredProcedure
                , new SqlParameter("@MaKH", _khachHang.MaKH));
        }
        public bool LuuThongTinKhachHang(ref string err, DTO_KhachHang _khachHang)
        {
            return data.MyExcuteNonQuery(ref err, "sp_KhachHang_Inser_Update", CommandType.StoredProcedure
                , new SqlParameter("@MaKH", _khachHang.MaKH)
                , new SqlParameter("@TenKH", _khachHang.TenKH)
                , new SqlParameter("@DiaChiKH", _khachHang.DiaChiKH)
                , new SqlParameter("@SoDienThoai", _khachHang.SoDienThoai)
                , new SqlParameter("@Email", _khachHang.Email)
                , new SqlParameter("@CMND", _khachHang.CMND));
        }



    }
}

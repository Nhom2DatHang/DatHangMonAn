
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DatHangMonAn.Bussiness
{
    public class BLL_PhanQuyen
    {
        cls_DataLayer data;
        public BLL_PhanQuyen(string path)
        {
            data = new cls_DataLayer(path);
        }

        public DataTable LoaiTaiKhoan(ref string err)
        {
            return data.GetDataTable(ref err, "SP_ChonTaiKhoan", CommandType.StoredProcedure, null);
        }

        public DataTable ChucNang(ref string err, string mataikhoan)
        {
            return data.GetDataTable(ref err, "SP_ChucNang_Combobox", CommandType.StoredProcedure, new SqlParameter("@mataikhoan", mataikhoan));
        }
        public bool insertPhanQuyen (ref string err, DTO.DTO_PhanQuyen _phanquyen)
        {
            return data.MyExcuteNonQuery(ref err, "SP_PhanQuyen_Insert", CommandType.StoredProcedure, new SqlParameter("@mataikhoan", _phanquyen.MaTaiKhoan), 
                new SqlParameter("@machucnang",_phanquyen.MaChucNang), new SqlParameter("@giatriquyen",_phanquyen.GiaTriQuyen));
        }

        public DataTable PhanQuyen(ref string err, string mataikhoan)
        {
            return data.GetDataTable(ref err, "SP_PhanQuyen_Select", CommandType.StoredProcedure, new SqlParameter("@mataikhoan", mataikhoan));
        }
    }
}

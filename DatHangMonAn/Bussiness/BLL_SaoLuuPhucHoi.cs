﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatHangMonAn.Bussiness
{
    public class BLL_SaoLuuPhucHoi
    {
        cls_DataLayer data;
        public string databasename = "";

        public BLL_SaoLuuPhucHoi(string path)
        {
            data = new cls_DataLayer(path);
            databasename = data.Databasename;
        }

        public bool SaoLuu(ref string err, string duongdanfile)
        {
            return data.MyExcuteNonQuery(ref err, "SP_SaoLuuDuLieu", System.Data.CommandType.StoredProcedure, new SqlParameter("@duongdan", duongdanfile));
        }

        public bool PhucHoi(ref string err, string duongdanfile, string databasename)
        {
            string sql = string.Format("USE Master \n ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" + " ALTER DATABASE {3} SET MULTI_USER", databasename, databasename, duongdanfile, databasename);
            return data.MyExcuteNonQuery(ref err, sql, System.Data.CommandType.Text, null);
        }
    }
}

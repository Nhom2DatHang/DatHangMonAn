using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatHangMonAn.Bussiness
{
    public class BLL_MonAn
    {
        cls_DataLayer data;
        public BLL_MonAn(string path)
        {
            data = new cls_DataLayer(path);
        }
    }
}

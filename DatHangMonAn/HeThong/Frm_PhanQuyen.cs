using DatHangMonAn.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatHangMonAn.HeThong
{
    public partial class Frm_PhanQuyen : Form
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
        }

        BLL_PhanQuyen bd;
        string err = "";

        private void loadcomboboxtaikhoan()
        {
            DataTable dt = new DataTable();
            dt = bd.LoaiTaiKhoan(ref err);
            cbotaikhoan.DataSource = dt;
            cbotaikhoan.DisplayMember = "TenTaiKhoan";
            cbotaikhoan.ValueMember = "MaTaiKhoan";
            cbotaikhoan.SelectedIndex = -1;
            cbotaikhoan.Text = "--Chọn tài khoản--";
        }

        private void loadcomboboxchucnang(string mataikhoan)
        {
            DataTable dt = new DataTable();
            dt = bd.ChucNang(ref err, mataikhoan);
            cbochucnang.DataSource = dt;
            cbochucnang.DisplayMember = "TenChucNang";
            cbochucnang.ValueMember = "MaChucNang";
            cbochucnang.SelectedIndex = -1;
            cbochucnang.Text = "--Chọn Chức năng--";
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhanQuyen(Cls_Main.duongdanfileketnoi);
            loadcomboboxtaikhoan();
        }

        DataTable dtdsQuyen;
        private void hienthiquyentheotaikhoan(string mataikhoan)
        {
            dtdsQuyen = new DataTable();
            dtdsQuyen = bd.PhanQuyen(ref err, mataikhoan);

            for (int i = 0; i < dtdsQuyen.Rows.Count; i++)
            {
                int tongquyen = Convert.ToInt32(dtdsQuyen.Rows[i]["GiaTriQuyen"].ToString());
                if ((tongquyen & 1) == 1)
                    dtdsQuyen.Rows[i]["Xem"] = 1;
                if ((tongquyen & 2) == 2)
                    dtdsQuyen.Rows[i]["Them"] = 1;
                if ((tongquyen & 4) == 4)
                    dtdsQuyen.Rows[i]["Sua"] = 1;
                if ((tongquyen & 8) == 8)
                    dtdsQuyen.Rows[i]["Xoa"] = 1;
            }
            dgvphanquyen.DataSource = dtdsQuyen;
        }

        private void cbotaikhoan_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cbotaikhoan.SelectedIndex > -1)
            {
                loadcomboboxchucnang(cbotaikhoan.SelectedValue.ToString());
                hienthiquyentheotaikhoan(cbotaikhoan.SelectedValue.ToString());
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

    }
}

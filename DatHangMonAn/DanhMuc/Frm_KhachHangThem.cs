using DatHangMonAn.Bussiness;
using DatHangMonAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatHangMonAn.DanhMuc
{
    public partial class Frm_KhachHangThem : Form
    {
        public Frm_KhachHangThem()
        {
            InitializeComponent();
        }

        private void Frm_KhachHangThem_Load(object sender, EventArgs e)
        {
            if (them == true)//hien thi form form them
            {
                HamTangMaSoKhachHang();
                txtmakhachhang.Text = MaKhachHang;
                lbltieude.Text = "Thêm thông tin khách hàng";
                txttenkhachhang.Focus();
            }
            else//load thong tin sua
            {
                GanGiaTriVaoCacControl(_khachHang);
                lbltieude.Text = "Chỉnh sửa thông tin khách hàng";
                txttenkhachhang.Focus();
            }
        }
        public bool them = false;
        BLL_KhachHang bd = new BLL_KhachHang(Cls_Main.duongdanfileketnoi);
        private string MaKhachHang = "";
        private string err = "";

        public DTO_KhachHang _khachHang = new DTO_KhachHang();
        /// <summary>
        /// /
        /// 
        /// </summary>
        private void HamTangMaSoKhachHang()
        {
            object _obj = null;
            _obj = bd.GetValue(ref err);
            if (_obj != null)
            {
                MaKhachHang = string.Format("KH{0:0000000}", Convert.ToInt32(_obj));

            }
        }


        private void GanGiaTriVaoCacControl(DTO_KhachHang _khachHang)
        {
            txtmakhachhang.Text = _khachHang.MaKH;
            txtcmnd.Text = _khachHang.CMND.ToString();
            txttenkhachhang.Text = _khachHang.TenKH;
            txtdiachi.Text = _khachHang.DiaChiKH;
            txtemail.Text = _khachHang.Email;
            txtsodienthoai.Text = _khachHang.SoDienThoai;
        }
        private void LayGiaTriTuCacControl()
        {
            _khachHang = new DTO_KhachHang();
            _khachHang.MaKH = txtmakhachhang.Text;
            _khachHang.Email = txtemail.Text;
            _khachHang.TenKH = txttenkhachhang.Text;
            _khachHang.DiaChiKH = txtdiachi.Text;
            _khachHang.SoDienThoai = txtsodienthoai.Text;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            {
                if (_khachHang != null)
                {
                    //cập nhật thông tin khách hàng
                    LayGiaTriTuCacControl();
                    // if (!string.IsNullOrEmpty(txtkihieu.Text))
                    {
                        if (bd.LuuThongTinKhachHang(ref err, _khachHang) == true)
                        {
                            MessageBox.Show("Khách hàng có mã số " + _khachHang.MaKH + " đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //  else
                    //    {
                    //       MessageBox.Show("Chưa nhập ký hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // }

                }
            }






        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

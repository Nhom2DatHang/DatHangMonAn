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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        BLL_KhachHang bd;
        DataTable dtDanhSachKhachHang;
        string err = "";
        DTO_KhachHang _khachHang;
        private void HienThiDanhSachKhachHang()
        {
            dtDanhSachKhachHang = new DataTable();
            dtDanhSachKhachHang = bd.LayDanhSachKhachHang(ref err);
            dgvdskhachhang.DataSource = dtDanhSachKhachHang;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            Frm_KhachHangThem _frmKhachHang = new Frm_KhachHangThem();

            _frmKhachHang.them = true;
            _frmKhachHang.ShowDialog();
            HienThiDanhSachKhachHang();
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            bd = new BLL_KhachHang(Cls_Main.duongdanfileketnoi);
            HienThiDanhSachKhachHang();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdskhachhang_Click(object sender, EventArgs e)
        {
            if (dgvdskhachhang.Rows.Count > 0)
            {
                _khachHang = new DTO_KhachHang();
                _khachHang.MaKH = dgvdskhachhang.CurrentRow.Cells["colmakh"].Value.ToString();
                _khachHang.Email = dgvdskhachhang.CurrentRow.Cells["colemail"].Value.ToString();
                _khachHang.TenKH = dgvdskhachhang.CurrentRow.Cells["coltenkh"].Value.ToString();
                _khachHang.DiaChiKH = dgvdskhachhang.CurrentRow.Cells["coldiachi"].Value.ToString();
                //_khachHang.CMND = Convert.ToInt32(dgvdskhachhang.CurrentRow.Cells["colcmnd"]);
                _khachHang.SoDienThoai = dgvdskhachhang.CurrentRow.Cells["colsodienthoai"].Value.ToString();

            }
        }
        private bool XoaThongTinKhachHang(DTO_KhachHang _khachHang)
        {
            return bd.XoaThongTinKhachHang(ref err, _khachHang);
        }

        int sodong = 0;
        private void btnxoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = dgvdskhachhang.Rows.Count - 1; i >= 0; i--)
            {
                if (dgvdskhachhang.Rows[i].Cells["coldelete"].Value.ToString() == "1")
                {
                    _khachHang = new DTO_KhachHang();
                    _khachHang.MaKH = dgvdskhachhang.Rows[i].Cells["colmakh"].Value.ToString();
                    if (_khachHang != null)
                    {
                        //gọi hàm xóa ra
                        if (MessageBox.Show("Bạn có muốn xóa không ?.\n Chọn OK,Hoặc Cancel", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            XoaThongTinKhachHang(_khachHang);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn khách hàng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            HienThiDanhSachKhachHang();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            {
                if (_khachHang != null)
                {
                    Frm_KhachHangThem _frmKhachHang = new Frm_KhachHangThem();
                    _frmKhachHang._khachHang = _khachHang;
                    _frmKhachHang.them = false;
                    _frmKhachHang.ShowDialog();
                    HienThiDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Chưa chọn khách hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
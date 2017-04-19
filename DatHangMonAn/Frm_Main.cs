using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DatHangMonAn.HeThong;
using DatHangMonAn.TacVu;
using DatHangMonAn.DanhMuc;

namespace DatHangMonAn
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_phanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PhanQuyen pq = new Frm_PhanQuyen();
            pq.MdiParent = this;
            pq.Show();
        }

        private void btn_datban_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DatMon datmon = new Frm_DatMon();
            datmon.MdiParent = this;
            datmon.Show();
        }

        private void btn_saoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SaoLuuPhucHoi saoluu = new Frm_SaoLuuPhucHoi();
            saoluu.ShowDialog();
        }

        private void bnt_phuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SaoLuuPhucHoi saoluu = new Frm_SaoLuuPhucHoi();
            saoluu.ShowDialog();
        }

        private void btn_doimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DoiMatKhau mk = new Frm_DoiMatKhau();
            mk.ShowDialog();
        }


        private void btn_khachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_KhachHang _khachHang = new Frm_KhachHang();
            _khachHang.MdiParent = this;
            _khachHang.Show();
        }

        private void btn_nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_NhanVien nhanvien = new Frm_NhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void btn_menu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.MdiParent = this;
            menu.Show();
        }

        private void btn_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
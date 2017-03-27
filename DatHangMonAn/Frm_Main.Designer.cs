namespace DatHangMonAn
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_menu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_datban = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_khachhang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_phanquyen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_doimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_saoluu = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_phuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Trợ giúp";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup8.Glyph")));
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_menu);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Menu";
            // 
            // btn_menu
            // 
            this.btn_menu.Caption = "Menu";
            this.btn_menu.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_menu.Glyph")));
            this.btn_menu.Id = 14;
            this.btn_menu.LargeWidth = 128;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_menu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_menu_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_datban);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Order";
            // 
            // btn_datban
            // 
            this.btn_datban.Caption = "Đặt bàn";
            this.btn_datban.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_datban.Glyph")));
            this.btn_datban.Id = 13;
            this.btn_datban.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datban.ItemAppearance.Disabled.Options.UseFont = true;
            this.btn_datban.LargeImageIndex = 12;
            this.btn_datban.LargeWidth = 128;
            this.btn_datban.Name = "btn_datban";
            this.btn_datban.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_datban.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_datban_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup8});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tác vụ chính";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_nhanvien);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Staff";
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Caption = "Nhân viên";
            this.btn_nhanvien.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.Glyph")));
            this.btn_nhanvien.Id = 12;
            this.btn_nhanvien.LargeWidth = 128;
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhanvien_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.Glyph")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_khachhang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Costumer";
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Caption = "Khách hàng";
            this.btn_khachhang.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.Glyph")));
            this.btn_khachhang.Id = 11;
            this.btn_khachhang.LargeWidth = 128;
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_khachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_khachhang_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_thoat);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Exit";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Glyph")));
            this.btn_thoat.Id = 9;
            this.btn_thoat.LargeWidth = 96;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thoat_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_phanquyen);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_doimatkhau);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Function";
            // 
            // btn_phanquyen
            // 
            this.btn_phanquyen.Caption = "Phân quyền";
            this.btn_phanquyen.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_phanquyen.Glyph")));
            this.btn_phanquyen.Id = 8;
            this.btn_phanquyen.LargeWidth = 96;
            this.btn_phanquyen.Name = "btn_phanquyen";
            this.btn_phanquyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_phanquyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phanquyen_ItemClick);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Caption = "Đổi mật khẩu";
            this.btn_doimatkhau.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_doimatkhau.Glyph")));
            this.btn_doimatkhau.Id = 7;
            this.btn_doimatkhau.LargeWidth = 96;
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_doimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_doimatkhau_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_saoluu);
            this.ribbonPageGroup4.ItemLinks.Add(this.bnt_phuchoi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Backup - Restore";
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.Caption = "Sao lưu";
            this.btn_saoluu.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_saoluu.Glyph")));
            this.btn_saoluu.Id = 2;
            this.btn_saoluu.LargeWidth = 96;
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_saoluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_saoluu_ItemClick);
            // 
            // bnt_phuchoi
            // 
            this.bnt_phuchoi.Caption = "Phục hồi";
            this.bnt_phuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("bnt_phuchoi.Glyph")));
            this.bnt_phuchoi.Id = 3;
            this.bnt_phuchoi.LargeWidth = 96;
            this.bnt_phuchoi.Name = "bnt_phuchoi";
            this.bnt_phuchoi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.bnt_phuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_phuchoi_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_dangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sign-out";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "Đăng xuất";
            this.btn_dangxuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Glyph")));
            this.btn_dangxuat.Id = 1;
            this.btn_dangxuat.LargeWidth = 96;
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_dangxuat,
            this.btn_saoluu,
            this.bnt_phuchoi,
            this.btn_doimatkhau,
            this.btn_phanquyen,
            this.btn_thoat,
            this.btn_khachhang,
            this.btn_nhanvien,
            this.btn_datban,
            this.btn_menu});
            this.ribbonControl1.LargeImages = this.imageCollection1;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(940, 182);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(128, 128);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "002-128.png");
            this.imageCollection1.Images.SetKeyName(1, "add.png");
            this.imageCollection1.Images.SetKeyName(2, "admin.png");
            this.imageCollection1.Images.SetKeyName(3, "backup.png");
            this.imageCollection1.Images.SetKeyName(4, "connect.png");
            this.imageCollection1.Images.SetKeyName(5, "delete.png");
            this.imageCollection1.Images.SetKeyName(6, "Documents Folder_48px.png");
            this.imageCollection1.Images.SetKeyName(7, "edit.png");
            this.imageCollection1.Images.SetKeyName(8, "Help_48px.png");
            this.imageCollection1.Images.SetKeyName(9, "list.png");
            this.imageCollection1.Images.SetKeyName(10, "log out.png");
            this.imageCollection1.Images.SetKeyName(11, "menu.png");
            this.imageCollection1.Images.SetKeyName(12, "order 1.png");
            this.imageCollection1.Images.SetKeyName(13, "order.png");
            this.imageCollection1.Images.SetKeyName(14, "restore.png");
            this.imageCollection1.Images.SetKeyName(15, "Save as_40px.png");
            this.imageCollection1.Images.SetKeyName(16, "Service Bell_48px.png");
            this.imageCollection1.Images.SetKeyName(17, "Table_96px.png");
            this.imageCollection1.Images.SetKeyName(18, "thoat.png");
            this.imageCollection1.Images.SetKeyName(19, "User Groups-96.png");
            this.imageCollection1.Images.SetKeyName(20, "user.png");
            this.imageCollection1.Images.SetKeyName(21, "view and edit.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup9});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 558);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btn_menu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_datban;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btn_nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_khachhang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_phanquyen;
        private DevExpress.XtraBars.BarButtonItem btn_doimatkhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_saoluu;
        private DevExpress.XtraBars.BarButtonItem bnt_phuchoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}
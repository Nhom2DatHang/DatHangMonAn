namespace DatHangMonAn.DanhMuc
{
    partial class Frm_KH
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KH));
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KH));
            this.dgvdskhachhang = new System.Windows.Forms.DataGridView();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
>>>>>>> origin/master
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
<<<<<<< HEAD
            this.listView1 = new System.Windows.Forms.ListView();
            this.coltenmonan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldvt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmamonan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvdskhachhang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdskhachhang
            // 
            this.dgvdskhachhang.AllowUserToAddRows = false;
            this.dgvdskhachhang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdskhachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdskhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdskhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstt,
            this.colmakh,
            this.coltenct,
            this.coldiachi,
            this.colsodienthoai,
            this.colemail,
            this.colcmnd,
            this.coldelete});
            this.dgvdskhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdskhachhang.Location = new System.Drawing.Point(0, 25);
            this.dgvdskhachhang.Name = "dgvdskhachhang";
            this.dgvdskhachhang.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdskhachhang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdskhachhang.RowTemplate.Height = 26;
            this.dgvdskhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdskhachhang.Size = new System.Drawing.Size(710, 268);
            this.dgvdskhachhang.TabIndex = 5;
            // 
            // colstt
            // 
            this.colstt.DataPropertyName = "STT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colstt.DefaultCellStyle = dataGridViewCellStyle3;
            this.colstt.HeaderText = "STT";
            this.colstt.Name = "colstt";
            this.colstt.ReadOnly = true;
            this.colstt.Width = 50;
            // 
            // colmakh
            // 
            this.colmakh.DataPropertyName = "MaKH";
            this.colmakh.HeaderText = "Mã số";
            this.colmakh.Name = "colmakh";
            this.colmakh.ReadOnly = true;
            // 
            // coltenct
            // 
            this.coltenct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coltenct.DataPropertyName = "TenKH";
            this.coltenct.HeaderText = "Tên Khách Hàng";
            this.coltenct.Name = "coltenct";
            this.coltenct.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "DiaChiKH";
            this.coldiachi.HeaderText = "Địa chỉ";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.DataPropertyName = "SDTKH";
            this.colsodienthoai.HeaderText = "Số điện thoại";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.ReadOnly = true;
            this.colsodienthoai.Width = 150;
            // 
            // colemail
            // 
            this.colemail.DataPropertyName = "Email";
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            // 
            // colcmnd
            // 
            this.colcmnd.DataPropertyName = "CMND";
            this.colcmnd.HeaderText = "CMND";
            this.colcmnd.Name = "colcmnd";
            // 
            // coldelete
            // 
            this.coldelete.DataPropertyName = "Xoa";
            this.coldelete.FalseValue = "0";
            this.coldelete.HeaderText = "Xóa";
            this.coldelete.Name = "coldelete";
            this.coldelete.TrueValue = "1";
            this.coldelete.Width = 50;
            // 
>>>>>>> origin/master
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
<<<<<<< HEAD
            this.btnthem.Size = new System.Drawing.Size(58, 22);
=======
            this.btnthem.Size = new System.Drawing.Size(59, 22);
>>>>>>> origin/master
            this.btnthem.Text = "Thêm";
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
<<<<<<< HEAD
            this.btnsua.Size = new System.Drawing.Size(46, 22);
=======
            this.btnsua.Size = new System.Drawing.Size(50, 22);
>>>>>>> origin/master
            this.btnsua.Text = "Sửa";
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
<<<<<<< HEAD
            this.btnxoa.Size = new System.Drawing.Size(47, 22);
=======
            this.btnxoa.Size = new System.Drawing.Size(48, 22);
>>>>>>> origin/master
            this.btnxoa.Text = "Xóa";
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(58, 22);
            this.btnthoat.Text = "Thoát";
            // 
<<<<<<< HEAD
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coltenmonan,
            this.coldvt,
            this.coldongia,
            this.colhinh,
            this.colmamonan});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 268);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // coltenmonan
            // 
            this.coltenmonan.Text = "Tên Món Ăn";
            // 
            // coldvt
            // 
            this.coldvt.Text = "DVT";
            // 
            // coldongia
            // 
            this.coldongia.Text = "Đơn giá";
            // 
            // colhinh
            // 
            this.colhinh.Text = "Hình";
            // 
            // colmamonan
            // 
            this.colmamonan.Text = "Mã món ăn";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(174, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
=======
>>>>>>> origin/master
            // Frm_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 293);
<<<<<<< HEAD
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_KH";
            this.Text = "Frm_KH";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
=======
            this.Controls.Add(this.dgvdskhachhang);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_KH";
            this.Text = "Frm_KH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdskhachhang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
>>>>>>> origin/master
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
=======
        private System.Windows.Forms.DataGridView dgvdskhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenct;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcmnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldelete;
>>>>>>> origin/master
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnthoat;
<<<<<<< HEAD
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coltenmonan;
        private System.Windows.Forms.ColumnHeader coldvt;
        private System.Windows.Forms.ColumnHeader coldongia;
        private System.Windows.Forms.ColumnHeader colhinh;
        private System.Windows.Forms.ColumnHeader colmamonan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
=======
>>>>>>> origin/master
    }
}
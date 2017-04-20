namespace DatHangMonAn.DanhMuc
{
    partial class Frm_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdskhachhang = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.coltenkh,
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
            this.dgvdskhachhang.Size = new System.Drawing.Size(910, 363);
            this.dgvdskhachhang.TabIndex = 3;
            this.dgvdskhachhang.Click += new System.EventHandler(this.dgvdskhachhang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(59, 22);
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(50, 22);
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(48, 22);
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(58, 22);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
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
            // coltenkh
            // 
            this.coltenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coltenkh.DataPropertyName = "TenKH";
            this.coltenkh.HeaderText = "Tên Khách Hàng";
            this.coltenkh.Name = "coltenkh";
            this.coltenkh.ReadOnly = true;
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
            this.colemail.Width = 120;
            // 
            // colcmnd
            // 
            this.colcmnd.DataPropertyName = "CMND";
            this.colcmnd.HeaderText = "CMND";
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Width = 120;
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
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 388);
            this.Controls.Add(this.dgvdskhachhang);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_KhachHang";
            this.Text = "Frm_KhachHang";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdskhachhang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdskhachhang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcmnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldelete;


    }
}
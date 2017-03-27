namespace DatHangMonAn.HeThong
{
    partial class Frm_PhanQuyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbxoa = new System.Windows.Forms.CheckBox();
            this.ckbsua = new System.Windows.Forms.CheckBox();
            this.ckbthem = new System.Windows.Forms.CheckBox();
            this.ckbxem = new System.Windows.Forms.CheckBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbochucnang = new System.Windows.Forms.ComboBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotaikhoan = new System.Windows.Forms.ComboBox();
            this.dgvphanquyen = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmachucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiatriquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colxem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colthem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphanquyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbxoa);
            this.panel1.Controls.Add(this.ckbsua);
            this.panel1.Controls.Add(this.ckbthem);
            this.panel1.Controls.Add(this.ckbxem);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbochucnang);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbotaikhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 104);
            this.panel1.TabIndex = 0;
            // 
            // ckbxoa
            // 
            this.ckbxoa.AutoSize = true;
            this.ckbxoa.Location = new System.Drawing.Point(603, 53);
            this.ckbxoa.Name = "ckbxoa";
            this.ckbxoa.Size = new System.Drawing.Size(54, 23);
            this.ckbxoa.TabIndex = 19;
            this.ckbxoa.Text = "Xóa";
            this.ckbxoa.UseVisualStyleBackColor = true;
            // 
            // ckbsua
            // 
            this.ckbsua.AutoSize = true;
            this.ckbsua.Location = new System.Drawing.Point(535, 55);
            this.ckbsua.Name = "ckbsua";
            this.ckbsua.Size = new System.Drawing.Size(55, 23);
            this.ckbsua.TabIndex = 18;
            this.ckbsua.Text = "Sửa";
            this.ckbsua.UseVisualStyleBackColor = true;
            // 
            // ckbthem
            // 
            this.ckbthem.AutoSize = true;
            this.ckbthem.Location = new System.Drawing.Point(603, 22);
            this.ckbthem.Name = "ckbthem";
            this.ckbthem.Size = new System.Drawing.Size(69, 23);
            this.ckbthem.TabIndex = 17;
            this.ckbthem.Text = "Thêm";
            this.ckbthem.UseVisualStyleBackColor = true;
            // 
            // ckbxem
            // 
            this.ckbxem.AutoSize = true;
            this.ckbxem.Location = new System.Drawing.Point(534, 22);
            this.ckbxem.Name = "ckbxem";
            this.ckbxem.Size = new System.Drawing.Size(59, 23);
            this.ckbxem.TabIndex = 16;
            this.ckbxem.Text = "Xem";
            this.ckbxem.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(404, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(95, 68);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chức năng:";
            // 
            // cbochucnang
            // 
            this.cbochucnang.FormattingEnabled = true;
            this.cbochucnang.Location = new System.Drawing.Point(135, 57);
            this.cbochucnang.Name = "cbochucnang";
            this.cbochucnang.Size = new System.Drawing.Size(263, 27);
            this.cbochucnang.TabIndex = 13;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(782, 16);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(119, 68);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu kết quả";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loại tài khoản";
            // 
            // cbotaikhoan
            // 
            this.cbotaikhoan.FormattingEnabled = true;
            this.cbotaikhoan.Location = new System.Drawing.Point(135, 20);
            this.cbotaikhoan.Name = "cbotaikhoan";
            this.cbotaikhoan.Size = new System.Drawing.Size(263, 27);
            this.cbotaikhoan.TabIndex = 10;
            this.cbotaikhoan.SelectionChangeCommitted += new System.EventHandler(this.cbotaikhoan_SelectionChangeCommitted_1);
            // 
            // dgvphanquyen
            // 
            this.dgvphanquyen.AllowUserToAddRows = false;
            this.dgvphanquyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvphanquyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvphanquyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvphanquyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphanquyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.colmachucnang,
            this.colchucnang,
            this.colgiatriquyen,
            this.colmataikhoan,
            this.coltentaikhoan,
            this.colxem,
            this.colthem,
            this.colsua,
            this.colxoa});
            this.dgvphanquyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphanquyen.Location = new System.Drawing.Point(0, 104);
            this.dgvphanquyen.Name = "dgvphanquyen";
            this.dgvphanquyen.RowHeadersVisible = false;
            this.dgvphanquyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvphanquyen.Size = new System.Drawing.Size(913, 266);
            this.dgvphanquyen.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // colmachucnang
            // 
            this.colmachucnang.DataPropertyName = "MaChucNang";
            this.colmachucnang.HeaderText = "mã chức năng";
            this.colmachucnang.Name = "colmachucnang";
            this.colmachucnang.ReadOnly = true;
            this.colmachucnang.Visible = false;
            // 
            // colchucnang
            // 
            this.colchucnang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colchucnang.DataPropertyName = "TenChucNang";
            this.colchucnang.HeaderText = "Chức năng";
            this.colchucnang.Name = "colchucnang";
            this.colchucnang.ReadOnly = true;
            // 
            // colgiatriquyen
            // 
            this.colgiatriquyen.DataPropertyName = "GiaTriQuyen";
            this.colgiatriquyen.HeaderText = "giatriquyen";
            this.colgiatriquyen.Name = "colgiatriquyen";
            this.colgiatriquyen.Visible = false;
            // 
            // colmataikhoan
            // 
            this.colmataikhoan.DataPropertyName = "MaTaiKhoan";
            this.colmataikhoan.HeaderText = "mã tài khoản";
            this.colmataikhoan.Name = "colmataikhoan";
            this.colmataikhoan.ReadOnly = true;
            this.colmataikhoan.Visible = false;
            // 
            // coltentaikhoan
            // 
            this.coltentaikhoan.DataPropertyName = "TenTaiKhoan";
            this.coltentaikhoan.HeaderText = "Tài khoản";
            this.coltentaikhoan.Name = "coltentaikhoan";
            this.coltentaikhoan.ReadOnly = true;
            this.coltentaikhoan.Width = 150;
            // 
            // colxem
            // 
            this.colxem.DataPropertyName = "Xem";
            this.colxem.FalseValue = "0";
            this.colxem.HeaderText = "Xem";
            this.colxem.Name = "colxem";
            this.colxem.TrueValue = "1";
            // 
            // colthem
            // 
            this.colthem.DataPropertyName = "Them";
            this.colthem.FalseValue = "0";
            this.colthem.HeaderText = "Thêm";
            this.colthem.Name = "colthem";
            this.colthem.TrueValue = "1";
            // 
            // colsua
            // 
            this.colsua.DataPropertyName = "Sua";
            this.colsua.FalseValue = "0";
            this.colsua.HeaderText = "Sửa";
            this.colsua.Name = "colsua";
            this.colsua.TrueValue = "1";
            // 
            // colxoa
            // 
            this.colxoa.DataPropertyName = "Xoa";
            this.colxoa.FalseValue = "0";
            this.colxoa.HeaderText = "Xóa";
            this.colxoa.Name = "colxoa";
            this.colxoa.TrueValue = "1";
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 370);
            this.Controls.Add(this.dgvphanquyen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_PhanQuyen";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphanquyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbxoa;
        private System.Windows.Forms.CheckBox ckbsua;
        private System.Windows.Forms.CheckBox ckbthem;
        private System.Windows.Forms.CheckBox ckbxem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbochucnang;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotaikhoan;
        private System.Windows.Forms.DataGridView dgvphanquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmachucnang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colchucnang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiatriquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltentaikhoan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colxem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colthem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colsua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colxoa;

    }
}
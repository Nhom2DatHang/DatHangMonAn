namespace DatHangMonAn.HeThong
{
    partial class Frm_SaoLuuPhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SaoLuuPhucHoi));
            this.lbltieude = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnlayduongdanfile = new System.Windows.Forms.ToolStripButton();
            this.btnsaoluu = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerr = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltieude.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.White;
            this.lbltieude.Location = new System.Drawing.Point(0, 25);
            this.lbltieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(678, 42);
            this.lbltieude.TabIndex = 9;
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlayduongdanfile,
            this.btnsaoluu,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnlayduongdanfile
            // 
            this.btnlayduongdanfile.Image = ((System.Drawing.Image)(resources.GetObject("btnlayduongdanfile.Image")));
            this.btnlayduongdanfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlayduongdanfile.Name = "btnlayduongdanfile";
            this.btnlayduongdanfile.Size = new System.Drawing.Size(125, 22);
            this.btnlayduongdanfile.Text = "Lấy đường dẫn file";
            this.btnlayduongdanfile.Click += new System.EventHandler(this.btnlayduongdanfile_Click);
            // 
            // btnsaoluu
            // 
            this.btnsaoluu.Image = ((System.Drawing.Image)(resources.GetObject("btnsaoluu.Image")));
            this.btnsaoluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsaoluu.Name = "btnsaoluu";
            this.btnsaoluu.Size = new System.Drawing.Size(69, 22);
            this.btnsaoluu.Text = "Sao Lưu";
            this.btnsaoluu.Click += new System.EventHandler(this.btnsaoluu_Click);
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
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(172, 71);
            this.txtduongdan.Margin = new System.Windows.Forms.Padding(4);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(484, 27);
            this.txtduongdan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đường dẫn file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 102);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerr
            // 
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(23, 17);
            this.lblerr.Text = "<>";
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
            // Frm_SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 124);
            this.Controls.Add(this.lbltieude);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_SaoLuuPhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SaoLuu_PhucHoi";
            this.Load += new System.EventHandler(this.Frm_SaoLuuPhucHoi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnlayduongdanfile;
        private System.Windows.Forms.ToolStripButton btnsaoluu;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerr;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
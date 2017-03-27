namespace DatHangMonAn
{
    partial class Frm_ThietLapKetNoi
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnkiemtraketnoi = new System.Windows.Forms.Button();
            this.btnluuketnoi = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdatabasename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbquyenketnoi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(341, 237);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 34);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnkiemtraketnoi
            // 
            this.btnkiemtraketnoi.Location = new System.Drawing.Point(159, 237);
            this.btnkiemtraketnoi.Name = "btnkiemtraketnoi";
            this.btnkiemtraketnoi.Size = new System.Drawing.Size(176, 34);
            this.btnkiemtraketnoi.TabIndex = 22;
            this.btnkiemtraketnoi.Text = "Kiểm tra kết nối";
            this.btnkiemtraketnoi.UseVisualStyleBackColor = true;
            this.btnkiemtraketnoi.Click += new System.EventHandler(this.btnkiemtraketnoi_Click);
            // 
            // btnluuketnoi
            // 
            this.btnluuketnoi.Location = new System.Drawing.Point(32, 237);
            this.btnluuketnoi.Name = "btnluuketnoi";
            this.btnluuketnoi.Size = new System.Drawing.Size(121, 34);
            this.btnluuketnoi.TabIndex = 21;
            this.btnluuketnoi.Text = "Lưu kết nối";
            this.btnluuketnoi.UseVisualStyleBackColor = true;
            this.btnluuketnoi.Click += new System.EventHandler(this.btnluuketnoi_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(172, 201);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(274, 27);
            this.txtpassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(172, 165);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(274, 27);
            this.txtuser.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "User ID:";
            // 
            // txtdatabasename
            // 
            this.txtdatabasename.Location = new System.Drawing.Point(172, 129);
            this.txtdatabasename.Name = "txtdatabasename";
            this.txtdatabasename.Size = new System.Drawing.Size(274, 27);
            this.txtdatabasename.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Database Name:";
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(172, 93);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(274, 27);
            this.txtservername.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server Name:";
            // 
            // ckbquyenketnoi
            // 
            this.ckbquyenketnoi.AutoSize = true;
            this.ckbquyenketnoi.Checked = true;
            this.ckbquyenketnoi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbquyenketnoi.Location = new System.Drawing.Point(28, 61);
            this.ckbquyenketnoi.Name = "ckbquyenketnoi";
            this.ckbquyenketnoi.Size = new System.Drawing.Size(195, 23);
            this.ckbquyenketnoi.TabIndex = 12;
            this.ckbquyenketnoi.Text = "Kết nối theo quyền SQL";
            this.ckbquyenketnoi.UseVisualStyleBackColor = true;
            this.ckbquyenketnoi.CheckedChanged += new System.EventHandler(this.ckbquyenketnoi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 49);
            this.label5.TabIndex = 24;
            this.label5.Text = "Thiết lập chuỗi kết nối";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 37);
            this.label6.TabIndex = 25;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_ThietLapKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkiemtraketnoi);
            this.Controls.Add(this.btnluuketnoi);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatabasename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbquyenketnoi);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThietLapKetNoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThietLapKetNoi";
            this.Load += new System.EventHandler(this.Frm_ThietLapKetNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnkiemtraketnoi;
        private System.Windows.Forms.Button btnluuketnoi;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdatabasename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbquyenketnoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
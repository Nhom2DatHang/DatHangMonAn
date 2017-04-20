using DatHangMonAn.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DatHangMonAn.HeThong
{
    public partial class Frm_SaoLuuPhucHoi : Form
    {
        public Frm_SaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        public bool saoluu = false;
        string err = "";
        BLL_SaoLuuPhucHoi bd = new BLL_SaoLuuPhucHoi(Cls_Main.duongdanfileketnoi);
        string databasename = "";

        private void btnlayduongdanfile_Click(object sender, EventArgs e)
        {
            if (saoluu == true)
            {
                SaveFileDialog _save = new SaveFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                _save.FileName = "Filebackup" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + ".bak";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtduongdan.Text = _save.FileName;
                }
            }
            else
            {
                OpenFileDialog _save = new OpenFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtduongdan.Text = _save.FileName;
                }
            }
        }

        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            if (saoluu == true)
            {
                //saoluu
                if (!string.IsNullOrEmpty(txtduongdan.Text))
                {
                    if (File.Exists(txtduongdan.Text))
                    {
                        File.Delete(txtduongdan.Text);
                    }
                    lblerr.Text = "Hệ thống đang tiến hành sao lưu...";
                    Application.DoEvents();
                    try
                    {
                        //thực hiện thủ tục sao lưu
                        if (bd.SaoLuu(ref err, txtduongdan.Text))
                        {
                            lblerr.Text = "Đã sao lưu thành công";
                            lblerr.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblerr.Text = "Sao lưu không thành công" + err;
                            lblerr.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {

                        err = ex.Message;
                        lblerr.Text = "Sao lưu không thành công" + err;
                        lblerr.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đường dẫn file bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //phục hội
                if (!string.IsNullOrEmpty(txtduongdan.Text))
                {

                    lblerr.Text = "Hệ thống đang tiến hành phục hồi...";
                    Application.DoEvents();
                    try
                    {
                        //thực hiện thủ tục sao lưu
                        databasename = bd.databasename;
                        if (bd.PhucHoi(ref err, txtduongdan.Text, databasename))
                        {
                            lblerr.Text = "Đã Phục hồi thành công";
                            lblerr.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblerr.Text = "Phục hồi không thành công" + err;
                            lblerr.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {

                        err = ex.Message;
                        lblerr.Text = "Phục hồi không thành công" + err;
                        lblerr.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đường dẫn file bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            if (saoluu == false)
            {
                btnsaoluu.Text = "Phục hồi";
                lbltieude.Text = "Phục hồi lại dữ liệu";
            }
            else
            {
                btnsaoluu.Text = "Sao Lưu";
                lbltieude.Text = "Sao lưu dữ liệu";
            }
        }
    }
}

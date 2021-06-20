using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.txtDN.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtDN.Focus();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                try
                {
                    NHANVIEN nv = db.NHANVIENs.Where(x => x.DIENTHOAI == txtDN.Text.Trim() && x.MK == txtMK.Text.Trim()).FirstOrDefault();
                    if (nv != null)
                    {
                        Form1 tt = new Form1(txtDN.Text.Trim());
                        tt.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng ");
                        txtDN.Clear();
                        txtMK.Clear();
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Đăng nhập thất bại!!");
                    txtDN.Clear();
                    txtMK.Clear();
                }
            }

        }

        private void txtDN_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Không được để trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Không được để trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    try
                    {
                        NHANVIEN nv = db.NHANVIENs.Where(x => x.DIENTHOAI == txtDN.Text.Trim() && x.MK == txtMK.Text.Trim()).FirstOrDefault();
                        if (nv != null)
                        {
                            Form1 tt = new Form1(txtDN.Text.Trim());
                            tt.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng ");
                            txtDN.Clear();
                            txtMK.Clear();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Đăng nhập thất bại!!");
                        txtDN.Clear();
                        txtMK.Clear();
                    }
                }
            }
        }
    }
}

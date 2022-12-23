using Anh_Coffee.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        private bool isHidePw = true;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un = txtUn.Text, pw = txtPw.Text;
            if (un.Length > 0 & un.Length > 0)
            {
                if (accountBUS.getAccount(un, pw) != null)
                {
                    StaffBUS.currentStaffID = accountBUS.getStaffIDByUn(un);
                    MessageBox.Show("Đăng nhập thành công!");
                    MDIMain mdi = new MDIMain();
                    this.Hide();
                    mdi.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (accountBUS.getAccount(un) != null)
                    {
                        MessageBox.Show("Mật khẩu không chính xác!");
                        txtPw.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản không chính xác!");
                        txtUn.Focus();
                    }
                }
            }
            else
            {
                if (un.Length == 0) errorProvider.SetError(txtUn, "Vui lòng nhập trường này");
                if (pw.Length == 0) errorProvider.SetError(txtPw, "Vui lòng nhập trường này");
            }
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtUn_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtPw_IconRightClick(object sender, EventArgs e)
        {
            isHidePw = !isHidePw;
            if (isHidePw)
            {
                txtPw.IconRight = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/hidePw.png");
                txtPw.PasswordChar = '\0';
            }
            else
            {
                txtPw.IconRight = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/showPw.png");
                txtPw.PasswordChar = '●';
            }
        }
    }
}

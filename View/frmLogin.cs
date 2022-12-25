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
            if (string.IsNullOrWhiteSpace(un) || string.IsNullOrWhiteSpace(pw))
            {
                if (string.IsNullOrWhiteSpace(un)) errorProvider.SetError(txtUn, "Vui lòng nhập trường này");
                if (string.IsNullOrWhiteSpace(pw)) errorProvider.SetError(txtPw, "Vui lòng nhập trường này");
            }
            else
            {
                if (accountBUS.getAccount(un, pw) != null)
                {
                    StaffBUS.currentStaffID = accountBUS.getStaffIDByUn(un);
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
                txtPw.IconRight = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/hide-pw.png");
                txtPw.PasswordChar = '\0';
            }
            else
            {
                txtPw.IconRight = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/show-pw.png");
                txtPw.PasswordChar = '●';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister f = new frmRegister();
            f.ShowDialog();
            this.Close();
        }
    }
}

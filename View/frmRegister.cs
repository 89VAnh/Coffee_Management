using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmRegister : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        AccountBUS accountBUS = new AccountBUS();
        PositionBUS positionBUS = new PositionBUS();

        Staff staffFromForm = null;
        Account accountFromForm = null;
        public frmRegister()
        {
            InitializeComponent();
        }
        private bool checkTextBox(Guna2TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập trường này");
                return false;
            }
            else return true;
        }
        private void getAccountFromForm()
        {
            if (checkTextBox(txtID) && checkTextBox(txtUn) && checkTextBox(txtPw) && checkTextBox(txtName) && checkTextBox(txtPhone) && checkTextBox(txtEmail) && checkTextBox(txtAddress))
            {
                staffFromForm = new Staff
                {
                    ID = txtID.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    PositionID = cboPosition.SelectedValue.ToString()
                };
                accountFromForm = new Account
                {
                    UserName = txtUn.Text,
                    Password = txtPw.Text,
                    StaffID = txtID.Text,
                    Staff = staffFromForm
                };
            }
            else
            {
                staffFromForm = null;
                accountFromForm = null;
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        private void frmRegister_Load(object sender, System.EventArgs e)
        {
            cboPosition.DataSource = positionBUS.getPositions();
            cboPosition.ValueMember = "ID";
            cboPosition.DisplayMember = "Name";
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            getAccountFromForm();
            if (staffFromForm != null && accountFromForm != null)
            {
                if (accountBUS.getAccountByStaffID(staffFromForm.ID) == null)
                {
                    if (accountBUS.getAccount(accountFromForm.UserName) == null)
                    {
                        if (txtPw.Text.Length >= 6)
                        {
                            accountBUS.Add(accountFromForm);
                            MessageBox.Show("Đăng ký thành công!");
                            frmLogin f = new frmLogin();
                            this.Hide();
                            f.ShowDialog();
                            this.Close();
                        }
                        else MessageBox.Show("Mật khẩu chứa tối thiểu 6 ký tự");
                    }
                    else MessageBox.Show("Tên tài khoản đã tồn tại!");
                }
                else MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}


using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmInfo : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        AccountBUS accountBUS = new AccountBUS();

        Staff staff;
        Account account;
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            staff = staffBUS.getStaffByID(StaffBUS.currentStaffID);
            txtStaffID.Text = staff.ID;
            txtName.Text = staff.Name;
            txtPhone.Text = staff.Phone;
            txtEmail.Text = staff.Email;
            txtAddress.Text = staff.Address;
            txtPosition.Text = staff.Position.Name;

            account = accountBUS.getAccountByStaffID(staff.ID);
            txtUn.Text = account.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận lưu thông tin", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                staffBUS.Update(new Staff { ID = staff.ID, Name = txtName.Text, Phone = txtPhone.Text, Email = txtEmail.Text, Address = txtAddress.Text, PositionID = staff.PositionID });
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            if (txtOldPw.Text.Length > 0 && txtNewPw.Text.Length > 0 && txtRePw.Text.Length > 0)
            {
                if (txtOldPw.Text == account.Password)
                {
                    if (txtNewPw.Text.Length >= 6)
                    {

                        if (txtRePw.Text == txtNewPw.Text)
                        {
                            accountBUS.Update(new Account
                            {
                                UserName = account.UserName,
                                Password = txtNewPw.Text,
                                StaffID = account.StaffID
                            });
                            MessageBox.Show("Đổi mật khẩu Thành công!");
                            txtOldPw.Clear();
                            txtNewPw.Clear();
                            txtRePw.Clear();
                        }
                        else MessageBox.Show("Mật khẩu nhập lại không chính xác!");
                    }
                    else errorProvider.SetError(txtNewPw, "Mật khẩu tối thiểu 6 ký tự!");
                }
                else MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");

        }

        private void txtNewPw_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}

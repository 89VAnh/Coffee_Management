using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmStaff : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        AccountBUS accountBUS = new AccountBUS();
        PositionBUS positionBUS = new PositionBUS();

        List<Account> accountList = new List<Account>();
        List<Position> positionList = new List<Position>();

        Staff staffFromForm = null;
        Account accountFromForm = null;
        public frmStaff()
        {
            InitializeComponent();
        }
        private void UpdateDgv(List<Account> accountList)
        {
            dgvStaff.DataSource = accountList.Select(x => new { x.Staff.ID, x.Staff.Name, x.Staff.Phone, x.Staff.Email, x.Staff.Address, PositionName = x.Staff.Position.Name, x.UserName, x.Password }).ToList();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            positionList = positionBUS.getPositions();
            cboPosition.DataSource = positionList;
            cboPosition.ValueMember = "ID";
            cboPosition.DisplayMember = "Name";

            accountList = accountBUS.getAccounts();
            UpdateDgv(accountList);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string staffID = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
            Account a = accountList.SingleOrDefault(x => x.StaffID == staffID);
            txtID.Text = staffID;
            txtName.Text = a.Staff.Name;
            txtPhone.Text = a.Staff.Phone;
            txtEmail.Text = a.Staff.Email;
            txtAddress.Text = a.Staff.Address;
            cboPosition.SelectedValue = a.Staff.PositionID;
            txtUserName.Text = a.UserName;
            txtPassword.Text = a.Password;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv(accountList.Where(x => x.Staff.Name.ToLower().Contains(txtSearch.Text)).ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboPosition.SelectedIndex = 0;
            UpdateDgv(accountList);
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

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgv(accountList
                .Where(x => x.Staff.PositionID == cboPosition.SelectedValue.ToString()).ToList());
        }

        private void getAccountFromForm()
        {
            if (checkTextBox(txtID) && checkTextBox(txtUserName) && checkTextBox(txtPassword) && checkTextBox(txtName) && checkTextBox(txtPhone) && checkTextBox(txtEmail) && checkTextBox(txtAddress))
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
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            getAccountFromForm();
            if (staffFromForm != null && accountFromForm != null)
            {
                if (accountList.Where(x => x.StaffID == staffFromForm.ID).Count() == 0)
                {
                    if (accountList.Where(
                        x => x.UserName == accountFromForm.UserName).Count() == 0)
                    {
                        if (txtPassword.Text.Length >= 6)
                        {
                            accountBUS.Add(accountFromForm);
                            accountList.Add(accountFromForm);
                            accountFromForm.Staff.Position = positionList.SingleOrDefault(x => x.ID == accountFromForm.Staff.PositionID);
                            MessageBox.Show("Thêm thành công!");
                            btnRefresh_Click(sender, e);
                        }
                        else MessageBox.Show("Mật khẩu chứa tối thiểu 6 ký tự");
                    }
                    else MessageBox.Show("Tên tài khoản đã tồn tại!");
                }
                else MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
        }
        private void UpdateStaff(Staff staff)
        {
            Staff s = accountList.SingleOrDefault(x => x.StaffID == staff.ID).Staff;
            s.Name = staff.Name;
            s.Phone = staff.Phone;
            s.Email = staff.Email;
            s.Address = staff.Address;
            s.PositionID = staff.PositionID;
            s.Position = positionList.SingleOrDefault(x => x.ID == staff.PositionID);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            getAccountFromForm();
            if (staffFromForm != null && accountFromForm != null)
            {
                Account account = accountList.SingleOrDefault(x => x.StaffID == staffFromForm.ID);
                if (account != null)
                {
                    if (account.UserName == accountFromForm.UserName)
                    {
                        if (account.Password == accountFromForm.Password)
                        {
                            staffBUS.Update(staffFromForm);
                            UpdateStaff(staffFromForm);
                            MessageBox.Show("Sửa thông tin thành công!");
                            btnRefresh_Click(sender, e);
                        }
                        else MessageBox.Show("Mật khẩu bị thay đổi!\nVui lòng đổi mật khẩu ở mục khác!");
                    }
                    else MessageBox.Show("Không được đổi tên tài khoản!");
                }
                else MessageBox.Show("Mã nhân viên không tồn tại!");
            }
        }
        private void btnChangePw_Click(object sender, EventArgs e)
        {
            getAccountFromForm();
            if (staffFromForm != null && accountFromForm != null)
            {
                Account account = accountList.SingleOrDefault(x => x.StaffID == staffFromForm.ID);
                if (account != null)
                {
                    if (account.UserName == accountFromForm.UserName)
                    {
                        if (accountFromForm.Password.Length >= 6)
                        {
                            accountBUS.Update(accountFromForm);
                            MessageBox.Show("Sửa mật khẩu thành công!");
                            btnRefresh_Click(sender, e);
                        }
                        else MessageBox.Show("Mật khẩu tối thiểu 6 ký tự!");
                    }
                    else MessageBox.Show("Không được đổi tên tài khoản!");
                }
                else MessageBox.Show("Mã nhân viên không tồn tại!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkTextBox(txtID))
            {
                Account a = accountList.SingleOrDefault(x => x.StaffID == txtID.Text);
                accountBUS.Delete(a);
                accountList.Remove(a);
                btnRefresh_Click(sender, e);
                MessageBox.Show("Xoá thành công!");
            }
            else MessageBox.Show("Chưa có nhân viên nào được chọn!");
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

    }
}

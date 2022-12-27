using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class MDIMain : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        public MDIMain()
        {
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuât không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StaffBUS.currentStaffID = "";
                this.Hide();
                frmLogin f = new frmLogin();
                f.ShowDialog();
                this.Close();
            }
        }
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
        private void MDIMain_Load(object sender, EventArgs e)
        {
            Staff staff = staffBUS.getStaffByID(StaffBUS.currentStaffID);
            sttWelcome.Text = "Xin chào " + staff.Name;
            if (staff.Position.Name == "Nhân viên")
            {
                quảnLýToolStripMenuItem1.Visible = false;
            }
        }
        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFood frm = new frmFood();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryFood frm = new frmCategoryFood();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}

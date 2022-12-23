using Anh_Coffee.Business;
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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmMain")
                {
                    f.Activate();
                    return;
                }
            }
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            sttWelcome.Text = "Xin chào "
                + staffBUS.getStaffByID(StaffBUS.currentStaffID).Name;
        }
    }
}

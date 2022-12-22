using Anh_Coffee.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuât không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                AccountBUS accountBUS = new AccountBUS();
                AccountBUS.currentAccount = "";
                this.Hide();
                frmLogin f = new frmLogin();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}

using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmBill : Form
    {
        BillBUS billBUS = new BillBUS();
        List<Bill> billList;
        public frmBill()
        {
            InitializeComponent();
        }
        private void UpdateDgv(List<Bill> bills)
        {
            dgvBill.DataSource = bills.Select(x => new { x.ID, x.TableCoffee.Name, x.CheckOut, x.Discount, x.TotalPrice }).ToList();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            billList = billBUS.getBills().Where(x => x.CheckOut != null).ToList();
            UpdateDgv(billList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDgv(billList);
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value <= dtpTo.Value)
            {
                UpdateDgv(billList.Where(x => x.CheckOut >= dtpFrom.Value && x.CheckOut <= dtpTo.Value).ToList());
            }
            else MessageBox.Show("Khoảng thời gian được chọn không hợp lệ!");
        }
    }
}

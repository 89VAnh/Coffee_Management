using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmPayBill : Form
    {
        BillBUS billBUS = new BillBUS();
        Bill bill;
        EventHandler acceptPay;
        public frmPayBill(int billID, TableCoffee table, List<BillInfo> billInfos, string discount, int totalPrice, int totalPriceAfterDiscount, EventHandler acceptPay)
        {
            InitializeComponent();
            var nfi = new NumberFormatInfo()
            {
                NumberDecimalDigits = 0,
                NumberGroupSeparator = "."
            };
            lblTable.Text = table.Name;
            lblTime.Text = DateTime.Now.ToString();
            lblTotalPrice.Text = totalPrice.ToString("N", nfi) + " đ";
            lblDiscount.Text = discount;
            lblPriceAfterDiscount.Text = totalPriceAfterDiscount.ToString("N", nfi) + " đ";
            dgvBill.DataSource = billInfos.Select(b => new { b.ID, b.Food.Name, b.Amount, b.Food.Price, Total = b.Amount * b.Food.Price, b.Note }).ToList();
            this.acceptPay = acceptPay;
            bill = new Bill
            {
                ID = billID,
                TableID = table.ID,
                Discount = discount,
                TotalPrice = totalPriceAfterDiscount,
                CheckOut = DateTime.Now,
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hoàn tất thanh toán", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                billBUS.Update(bill);
                MessageBox.Show("Thanh toán thành công!");
                this.acceptPay(sender, e);
                this.Close();
            }
        }
    }
}

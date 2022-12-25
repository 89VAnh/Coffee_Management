using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmBill : Form
    {

        public frmBill(string table, List<BillInfo> billInfos, string discount, int totalPrice, int totalPriceAfterDiscount)
        {
            InitializeComponent();
            var nfi = new NumberFormatInfo()
            {
                NumberDecimalDigits = 0,
                NumberGroupSeparator = "."
            };
            lblTable.Text = table;
            lblTime.Text = DateTime.Now.ToString();
            lblTotalPrice.Text = totalPrice.ToString("N", nfi) + " đ";
            lblDiscount.Text = discount;
            lblPriceAfterDiscount.Text = totalPriceAfterDiscount.ToString("N", nfi) + " đ";
            dgvBill.DataSource = billInfos.Select(b => new { b.ID, b.Food.Name, b.Amount, b.Food.Price, Total = b.Amount * b.Food.Price, b.Note }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}

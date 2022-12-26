using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
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
    public partial class frmStatistic : Form
    {
        BillBUS billBUS = new BillBUS();
        public frmStatistic()
        {
            InitializeComponent();
        }
        private void frmStatistic_Load(object sender, EventArgs e)
        {
            List<Bill> billList = billBUS.getBills();
            chartRevenue.DataSource = billBUS.GetRevenue();
        }
    }
}

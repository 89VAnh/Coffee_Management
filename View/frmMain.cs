using Anh_Coffee.BUS;
using Anh_Coffee.DAO;
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
    public partial class frmMain : Form
    {
        TableBUS tableBUS = new TableBUS();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<TableCoffee> tableCoffees = tableBUS.getTableCoffees();
            foreach (TableCoffee t in tableCoffees)
            {
                Table tb = new Table(t.Name, t.Status);
                tb.Tag = t.ID;
                flpTable.Controls.Add(tb);
            }
        }
    }
}

using Anh_Coffee.BUS;
using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using Guna.UI2.WinForms;
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
        BillInfoBUS billInfoBUS = new BillInfoBUS();
        BillBUS billBUS = new BillBUS();

        int selectedTable = 0;
        int selectedBillInfo = 0;
        List<BillInfo> billInfoList = new List<BillInfo>();
        public frmMain()
        {
            InitializeComponent();
        }
        private void UpdateDgv()
        {
            billInfoList = billInfoBUS.GetBillInfoesInTable(selectedTable);
            dgvBill.DataSource = billInfoList.Select(b => new { b.ID, b.Food.Name, b.Amount, b.Food.Price, Total = b.Amount * b.Food.Price }).ToList();
        }
        private void table_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            selectedTable = (int)btn.Tag;
            UpdateDgv();
        }
        private void setCboChangeTableData()
        {
            cboChangeTable.DataSource = tableBUS.getEmptyTable();
            cboChangeTable.ValueMember = "ID";
            cboChangeTable.DisplayMember = "Name";

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            List<TableCoffee> tableCoffees = tableBUS.getTableCoffees();
            foreach (TableCoffee t in tableCoffees)
            {
                Table tb = new Table(t.ID, t.Name, t.Status, table_Click);
                flpTable.Controls.Add(tb);
            }
            setCboChangeTableData();
            dgvBill.DefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
        private void setTableStatus(int tableID, string status)
        {
            Table tb = flpTable.Controls[tableID - 1] as Table;
            tb.UpdateStatus(status);
            tableBUS.setTableStatus(tableID, status);
        }
        private void AddFood(object sender, EventArgs e)
        {
            UpdateDgv();
            setTableStatus(selectedTable, "Có người");
            setCboChangeTableData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedTable > 0)
            {
                frmAddFood f = new frmAddFood(selectedTable, AddFood);
                f.ShowDialog();
            }
            else MessageBox.Show("Vui lòng lựa chọn bàn!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvBill_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvBill.Rows.Count == 0)
                txtTotalPrice.Text = "0";
            else
            {
                try
                {
                    int sum = 0;
                    foreach (DataGridViewRow r in dgvBill.Rows)
                    {
                        sum += (int)r.Cells[5].Value;
                    }
                    txtTotalPrice.Text = sum.ToString();
                }
                catch { }
            }
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBillInfo = (int)dgvBill.SelectedRows[0].Cells[1].Value;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedBillInfo > 0)
            {
                billInfoBUS.Delete(selectedBillInfo);
                UpdateDgv();
            }
            else MessageBox.Show("Vui lòng chọn món!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if (selectedTable > 0)
            {
                if (billInfoBUS.GetBillInfoesInTable(selectedTable).Count > 0)
                {
                    int newTableID = (int)cboChangeTable.SelectedValue;
                    setTableStatus(selectedTable, "Trống");
                    setTableStatus(newTableID, "Có người");
                    billBUS.Update(selectedTable, newTableID);
                    setCboChangeTableData();
                    MessageBox.Show($"Đã đổi bàn {selectedTable} => {newTableID} thành công");
                    selectedTable = newTableID;
                }
                else MessageBox.Show("Bàn được chọn không hợp lệ!");
            }
            else MessageBox.Show("Vui lòng lựa chọn bàn!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BillInfoUpdated(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBillInfo > 0)
            {
                int billInfoID = (int)dgvBill.SelectedRows[0].Cells[1].Value;
                BillInfo billInfo = billInfoList
                    .SingleOrDefault(x => x.ID == billInfoID);
                frmEditFood f = new frmEditFood(billInfo, BillInfoUpdated);
                f.ShowDialog();
            }
            else MessageBox.Show("Vui lòng chọn món!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmMain : Form
    {
        //BUS
        TableBUS tableBUS = new TableBUS();
        BillInfoBUS billInfoBUS = new BillInfoBUS();
        BillBUS billBUS = new BillBUS();
        CategoryFoodBUS categoryFoodBUS = new CategoryFoodBUS();
        FoodBUS foodBUS = new FoodBUS();
        AccountBUS accountBUS = new AccountBUS();

        // Variable
        int selectedFoodID = 0;
        int selectedTableID = 0;
        int selectedBillInfoID = 0;
        List<Food> foodList = new List<Food>();
        List<BillInfo> billInfoListInSelectedTable = new List<BillInfo>();
        List<TableCoffee> tableList = new List<TableCoffee>();
        public frmMain()
        {
            InitializeComponent();
        }
        // Custom function
        private void UpdateDgvBill()
        {
            dgvBill.DataSource = billInfoListInSelectedTable.Select(b => new { b.ID, b.Food.Name, b.Amount, b.Food.Price, Total = b.Amount * b.Food.Price, b.Note }).ToList();
        }
        private void UpdateDgvFood(List<Food> foods)
        {
            dgvFood.DataSource = foods.Select(f => new { f.ID, f.Name, f.Price, CategoryName = f.CategoryFood.Name }).ToList();
        }
        private void setCboChangeTableData()
        {
            cboChangeTable.DataSource = tableList.Where(x => x.Status == "Trống").ToList();
            cboChangeTable.ValueMember = "ID";
            cboChangeTable.DisplayMember = "Name";
        }
        private void setTableStatus(int tableID, string status)
        {
            Table tb = flpTable.Controls[tableID - 1] as Table;
            if (status != tb.GetStatus())
            {
                tb.UpdateStatus(status);
                tableBUS.setTableStatus(tableID, status);
            }
        }

        //EventHandler
        //BillInfo
        private void frmMain_Load(object sender, EventArgs e)
        {
            tableList = tableBUS.getTableCoffees();
            foreach (TableCoffee t in tableList)
            {
                Table tb = new Table(t.ID, t.Name, t.Status, table_Click);
                flpTable.Controls.Add(tb);
            }
            // cboTable
            cboTable.DataSource = tableList;
            cboTable.ValueMember = "ID";
            cboTable.DisplayMember = "Name";

            // cboChangeTable
            setCboChangeTableData();

            // cboCategoryFood
            cboCategoryFood.DataSource = categoryFoodBUS.getCategoryFoods();
            cboCategoryFood.ValueMember = "ID";
            cboCategoryFood.DisplayMember = "Name";

            foodList = foodBUS.getFoods();
            UpdateDgvFood(foodList);

            dgvFood.DefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvBill.DefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void table_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            selectedTableID = (int)btn.Tag;
            cboTable.SelectedValue = selectedTableID;
            billInfoListInSelectedTable = billInfoBUS.GetBillInfoesInTable(selectedTableID);
            UpdateDgvBill();
            numAmount.Value = 1;
            txtNote.Text = "";
        }
        private void dgvBill_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvBill.Rows.Count == 0)
                txtTotalPrice.Text = "0";
            else
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
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBillInfoID = (int)dgvBill.SelectedRows[0].Cells[0].Value;
            numAmount.Value = (int)dgvBill.SelectedRows[0].Cells[2].Value;
            txtNote.Text = dgvBill.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if (selectedTableID > 0)
                if (billInfoBUS.GetBillInfoesInTable(selectedTableID).Count > 0)
                {
                    int newTableID = (int)cboChangeTable.SelectedValue;
                    setTableStatus(selectedTableID, "Trống");
                    setTableStatus(newTableID, "Có người");
                    billBUS.Update(selectedTableID, newTableID);
                    setCboChangeTableData();
                    MessageBox.Show($"Đã đổi bàn {selectedTableID} => {newTableID} thành công");
                    selectedTableID = newTableID;
                    billInfoListInSelectedTable = billInfoListInSelectedTable = billInfoBUS.GetBillInfoesInTable(selectedTableID);
                    UpdateDgvBill();
                }
                else MessageBox.Show("Bàn được chọn không hợp lệ!");
            else MessageBox.Show("Vui lòng lựa chọn bàn!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Del
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedBillInfoID > 0)
            {
                BillInfo billInfo = billInfoListInSelectedTable.SingleOrDefault(x => x.ID == selectedBillInfoID);
                billInfoBUS.Delete(billInfo);
                billInfoListInSelectedTable.Remove(billInfo);
                UpdateDgvBill();
            }
            else MessageBox.Show("Vui lòng chọn món!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBillInfoID > 0)
                if (MessageBox.Show("Xác nhận đổi số lượng và ghi chú", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BillInfo bI = billInfoListInSelectedTable.SingleOrDefault(x => x.ID == selectedBillInfoID);
                    bI.Amount = (int)numAmount.Value;
                    bI.Note = txtNote.Text;
                    billInfoBUS.Update(bI);
                    UpdateDgvBill();
                }
                else MessageBox.Show("Vui lòng chọn món!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Food
        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedTableID > 0)
                if (selectedFoodID > 0)
                {
                    int id;
                    Bill bill = billBUS.getBillIDByTableID(selectedTableID);
                    if (bill == null)
                    {
                        id = billBUS.getNewID();
                        billBUS.Add(new Bill { ID = id, TableID = selectedTableID, StaffID = StaffBUS.currentStaffID, TotalPrice = 0 });
                        bill = billBUS.getBillIDByTableID(selectedTableID);
                    }
                    else
                        id = bill.ID;
                    BillInfo newbI = new BillInfo { ID = billInfoBUS.getNewID(), BillID = id, FoodID = selectedFoodID, Amount = (int)numAmount.Value, Note = txtNote.Text };

                    MessageBox.Show($"Đã thêm vào bàn {selectedTableID} : {newbI.Amount} {foodList.SingleOrDefault(f => f.ID == newbI.FoodID).Name}");

                    BillInfo billInfo = billInfoListInSelectedTable.SingleOrDefault(x => x.BillID == newbI.BillID && x.FoodID == newbI.FoodID);
                    if (billInfo == null)
                    {
                        billInfoBUS.Add(newbI);
                        billInfoListInSelectedTable.Add(newbI);
                    }
                    else
                    {
                        billInfoBUS.AddAmount(billInfo.ID, newbI.Amount, newbI.Note);
                    }
                    UpdateDgvBill();

                    setTableStatus(selectedTableID, "Có người");
                    setCboChangeTableData();
                }
                else MessageBox.Show("Vui lòng chọn món!");
            else MessageBox.Show("Vui lòng lựa chọn bàn!", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Food> foods = foodList.Where(f => f.CategoryID == Convert.ToInt32(cboCategoryFood.SelectedValue)).ToList();
                cboFood.DataSource = foods;
                cboFood.ValueMember = "ID";
                cboFood.DisplayMember = "Name";
                UpdateDgvFood(foods);
            }
            catch { };
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFoodID = (int)dgvFood.SelectedRows[0].Cells[0].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgvFood(foodList.Where(f => f.Name.ToLower().Contains(txtSearch.Text)).ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }
    }
}

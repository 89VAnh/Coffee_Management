using Anh_Coffee.BUS;
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
    public partial class frmAddFood : Form
    {
        CategoryFoodBUS categoryFoodBUS = new CategoryFoodBUS();
        FoodBUS foodBUS = new FoodBUS();
        BillInfoBUS billInfoBUS = new BillInfoBUS();
        BillBUS billBUS = new BillBUS();
        AccountBUS accountBUS = new AccountBUS();

        List<Food> foodList = new List<Food>();
        int selectedFoodID = 0;
        int selectedTableID = 0;
        EventHandler eventAddFood;
        public frmAddFood(int tableID, EventHandler AddFood)
        {
            InitializeComponent();
            selectedTableID = tableID;
            eventAddFood = AddFood;
        }

        private void UpdateDgv(List<Food> foods)
        {
            dgvFood.DataSource = foods.Select(f => new { f.ID, f.Name, f.Price, CategoryName = f.CategoryFood.Name }).ToList();
        }


        private void frmAddFood_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm món bàn " + selectedTableID;
            selectedFoodID = 0;
            cboCategoryFood.DataSource = categoryFoodBUS.getCategoryFoods();
            cboCategoryFood.ValueMember = "ID";
            cboCategoryFood.DisplayMember = "Name";
            dgvFood.DefaultCellStyle.Font = new Font("SegoeUI", 10);
            foodList = foodBUS.getFoods();
            UpdateDgv(foodList);
        }

        private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Food> foods = foodList.Where(f => f.CategoryID == Convert.ToInt32(cboCategoryFood.SelectedValue)).ToList();
                cboFood.DataSource = foods;
                cboFood.ValueMember = "ID";
                cboFood.DisplayMember = "Name";
                UpdateDgv(foods);
            }
            catch { };
        }
        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateDgv(foodList.Where(f => f.ID == Convert.ToInt32(cboFood.SelectedValue)).ToList());
            }
            catch { }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv(foodList.Where(f => f.Name.Contains(txtSearch.Text)).ToList());
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFoodID = (int)dgvFood.SelectedRows[0].Cells[0].Value;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedFoodID > 0)
            {
                int id;
                Bill bill = billBUS.getBillIDByTableID(selectedTableID);
                if (bill == null)
                {
                    id = billBUS.getNewID();
                    billBUS.Add(new Bill { ID = id, TableID = selectedTableID, Staff = AccountBUS.currentAccount, TotalPrice = 0 });
                    bill = billBUS.getBillIDByTableID(selectedTableID);
                }
                else
                {
                    id = bill.ID;
                }
                BillInfo newbI = new BillInfo { ID = billInfoBUS.getNewID(), BillID = id, FoodID = selectedFoodID, Amount = (int)numAmount.Value, Note = txtNote.Text };

                billInfoBUS.Add(newbI);
                MessageBox.Show($"Đã thêm vào bàn {selectedTableID} : {newbI.Amount} {foodList.SingleOrDefault(f => f.ID == newbI.FoodID).Name}");
                eventAddFood(sender, e);
            }
            else MessageBox.Show("Vui lòng chọn món!");
        }

    }
}

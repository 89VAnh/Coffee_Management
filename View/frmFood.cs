using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmFood : Form
    {
        FoodBUS foodBUS = new FoodBUS();
        CategoryFoodBUS categoryFoodBUS = new CategoryFoodBUS();

        List<Food> foodList = new List<Food>();
        int selectedFoodID = 0;
        public frmFood()
        {
            InitializeComponent();
        }

        private void UpdateDgv(List<Food> foodList)
        {
            dgvFood.DataSource = foodList.Select(f => new { f.ID, f.Name, CategoryName = f.CategoryFood.Name, f.Price }).ToList();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            cboCategoryFood.DataSource = categoryFoodBUS.getCategoryFoods();
            cboCategoryFood.ValueMember = "ID";
            cboCategoryFood.DisplayMember = "Name";
            foodList = foodBUS.getFoods();
            UpdateDgv(foodList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv(foodList.Where(f => f.Name.ToLower().Contains(txtSearch.Text)).ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Food> foods = foodList.Where(f => f.CategoryID == Convert.ToInt32(cboCategoryFood.SelectedValue)).ToList();
                UpdateDgv(foods);
            }
            catch { };
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFoodID = (int)dgvFood.SelectedRows[0].Cells[0].Value;
            Food food = foodList.SingleOrDefault(x => x.ID == selectedFoodID);
            txtName.Text = food.Name;
            cboCategoryFood.SelectedValue = food.CategoryID;
            numPrice.Value = food.Price;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            cboCategoryFood.SelectedIndex = 0;
            numPrice.Value = 0;
            UpdateDgv(foodList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food newFood = new Food
            {
                ID = foodList.Count + 1,
                Name = txtName.Text,
                CategoryID = (int)cboCategoryFood.SelectedValue,
                Price = (int)numPrice.Value
            };
            foodBUS.Add(newFood);

            foodList.Add(newFood);
            UpdateDgv(foodList);
            MessageBox.Show("Thêm thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedFoodID > 0)
            {
                Food food = new Food
                {
                    ID = selectedFoodID,
                    Name = txtName.Text,
                    CategoryID = (int)cboCategoryFood.SelectedValue,
                    Price = (int)numPrice.Value
                };
                foodBUS.Update(food);
                UpdateDgv(foodList);
                MessageBox.Show("Sửa thành công!");
            }
            else MessageBox.Show("Vui lòng chọn đồ ăn!", "Thao tác không hợp lệ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFoodID > 0)
            {
                Food food = foodList.SingleOrDefault(x => x.ID == selectedFoodID);
                foodBUS.Delete(food);

                foodList.Remove(food);
                UpdateDgv(foodList);
                MessageBox.Show("Xoá thành công!");
            }
            else MessageBox.Show("Vui lòng chọn đồ ăn!", "Thao tác không hợp lệ");
        }
    }
}

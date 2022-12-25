using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmCategoryFood : Form
    {
        CategoryFoodBUS categoryFoodBUS = new CategoryFoodBUS();

        List<CategoryFood> categoryFoodList;
        int selectedCategoryFoodID = 0;

        public frmCategoryFood()
        {
            InitializeComponent();
        }
        private void UpdateDgv(List<CategoryFood> categoryFoodList)
        {
            dgvCategoryFood.DataSource = categoryFoodList
                .Select(x => new { x.ID, x.Name, Amount = x.Foods.Count }).ToList();

        }
        private void frmCategoryFoods_Load(object sender, EventArgs e)
        {
            categoryFoodList = categoryFoodBUS.getCategoryFoods();
            UpdateDgv(categoryFoodList);
        }

        private void dgvCategoryFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategoryFoodID = (int)dgvCategoryFood.SelectedRows[0].Cells[0].Value;
            txtName.Text = dgvCategoryFood.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv(categoryFoodList.Where(x => x.Name.ToLower().Contains(txtSearch.Text)).ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryFood newCF = new CategoryFood
            {
                ID = categoryFoodList.Count + 1,
                Name = txtName.Text
            };
            categoryFoodBUS.Add(newCF);

            categoryFoodList.Add(newCF);
            UpdateDgv(categoryFoodList);
            MessageBox.Show("Thêm danh mục món thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedCategoryFoodID > 0)
            {
                CategoryFood cF = new CategoryFood
                {
                    ID = selectedCategoryFoodID,
                    Name = txtName.Text
                };
                categoryFoodBUS.Update(cF);
                UpdateDgv(categoryFoodList);
                MessageBox.Show("Sửa danh mục món thành công!");
            }
            else MessageBox.Show("Vui lòng chọn 1 danh mục đồ ăn!", "Thao tác không hợp lệ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryFoodID > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục món không?\n Các món trong danh mục này sẽ bị xoá", "Cẩn thận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CategoryFood cF = categoryFoodList
                        .SingleOrDefault(x => x.ID == selectedCategoryFoodID);
                    categoryFoodBUS.Delete(cF);

                    categoryFoodList.Remove(cF);
                    UpdateDgv(categoryFoodList);
                    MessageBox.Show("Xoá thành công!");
                }
            }
            else MessageBox.Show("Vui lòng chọn 1 danh mục đồ ăn!", "Thao tác không hợp lệ");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            UpdateDgv(categoryFoodList);
        }
    }
}

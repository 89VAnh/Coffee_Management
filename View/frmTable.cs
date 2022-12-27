using Anh_Coffee.Business;
using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class frmTable : Form
    {
        TableBUS tableBUS = new TableBUS();

        List<TableCoffee> tableList;
        int selectedTableID = 0;
        public frmTable()
        {
            InitializeComponent();
        }
        private void UpdateDgv(List<TableCoffee> tables)
        {
            dgvTable.DataSource = tables.Select(x => new { x.ID, x.Name, x.Status }).ToList();
        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            tableList = tableBUS.getTableCoffees();
            UpdateDgv(tableList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv(tableList.Where(x => x.Name.ToLower().Contains(txtSearch.Text)).ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTableID = (int)dgvTable.SelectedRows[0].Cells[0].Value;
            txtName.Text = dgvTable.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            UpdateDgv(tableList);
        }


        private string getTableStatus(int tableID)
        {
            return tableList.SingleOrDefault(x => x.ID == selectedTableID).Status;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                TableCoffee newT = new TableCoffee
                {
                    ID = tableList.Count + 1,
                    Name = txtName.Text,
                    Status = "Trống"
                };
                tableBUS.Add(newT);

                tableList.Add(newT);
                UpdateDgv(tableList);
                MessageBox.Show("Thêm bàn thành công!");
            }
            else MessageBox.Show("Vui lòng nhập tên bàn");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedTableID > 0)
            {
                if (txtName.Text.Length > 0)
                {
                    TableCoffee newTable = new TableCoffee
                    {
                        ID = selectedTableID,
                        Name = txtName.Text,
                        Status = getTableStatus(selectedTableID)
                    };
                    tableBUS.Update(newTable);
                    UpdateDgv(tableList);
                    MessageBox.Show("Sửa tên bàn thành công!");
                }
                else MessageBox.Show("Vui lòng nhập tên bàn");
            }
            else MessageBox.Show("Vui lòng chọn 1 bàn!", "Thao tác không hợp lệ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTableID > 0)
            {
                if (getTableStatus(selectedTableID) == "Trống")
                {

                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá bàn này không?", "Cẩn thận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TableCoffee cF = tableList
                            .SingleOrDefault(x => x.ID == selectedTableID);
                        tableBUS.Delete(cF);

                        tableList.Remove(cF);
                        UpdateDgv(tableList);
                        MessageBox.Show("Xoá bàn thành công!");
                    }
                }
                else MessageBox.Show("Không cho phép xoá bàn có người!");
            }
            else MessageBox.Show("Vui lòng chọn 1 bàn!", "Thao tác không hợp lệ");
        }
    }
}

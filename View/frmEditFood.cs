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
    public partial class frmEditFood : Form
    {
        BillInfoBUS billInfoBUS = new BillInfoBUS();
        FoodBUS foodBUS = new FoodBUS();

        private BillInfo billInfo;
        EventHandler BillInfoUpdated;
        public frmEditFood(BillInfo billInfo, EventHandler BillInfoUpdated)
        {
            InitializeComponent();
            this.billInfo = billInfo;
            this.BillInfoUpdated = BillInfoUpdated;
        }
        private void frmEditFood_Load(object sender, EventArgs e)
        {
            cboFood.DataSource = foodBUS.getFoods();
            cboFood.ValueMember = "ID";
            cboFood.DisplayMember = "Name";
            cboFood.SelectedValue = billInfo.FoodID;
            numAmount.Value = billInfo.Amount;
            txtNote.Text = billInfo.Note;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            billInfoBUS.Update(
                new BillInfo
                {
                    ID = billInfo.ID,
                    BillID = billInfo.BillID,
                    FoodID = (int)cboFood.SelectedValue,
                    Amount = (int)numAmount.Value,
                    Note = txtNote.Text
                });
            BillInfoUpdated(sender, e);
        }


    }
}

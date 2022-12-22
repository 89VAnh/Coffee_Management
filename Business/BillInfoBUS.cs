using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.Business
{
    public class BillInfoBUS
    {
        BillInfoDAO billInfoDAO = new BillInfoDAO();
        BillDAO billDAO = new BillDAO();

        public List<BillInfo> GetBillInfoesInTable(int tableID)
        {
            Bill bill = billDAO.getBillByTableID(tableID);
            if (bill != null)
                return billInfoDAO.GetBillInfoesInBill(bill.ID);
            else return new List<BillInfo>();
        }
        public int getNewID()
        {
            return billInfoDAO.getNewID();
        }
        public void AddAmount(int bIID, int amnout, string note)
        {
            billInfoDAO.AddAmount(bIID, amnout, note);
        }
        public void Add(BillInfo billInfo)
        {
            BillInfo bI = billInfoDAO.GetBillInfoesInBill(billInfo.BillID).SingleOrDefault(x => x.FoodID == billInfo.FoodID);
            if (bI == null)
                billInfoDAO.Add(billInfo);
            else AddAmount(bI.ID, billInfo.Amount, billInfo.Note);
        }
        public void Update(BillInfo billInfo)
        {
            billInfoDAO.Update(billInfo);
        }
        public void Delete(int id)
        {
            billInfoDAO.Delete(id);
        }
    }
}

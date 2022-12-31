using Anh_Coffee.DataAccess;
using System.Collections.Generic;

namespace Anh_Coffee.Business
{
    public class BillInfoBUS
    {
        BillInfoDAO billInfoDAO = new BillInfoDAO();
        BillBUS billBUS = new BillBUS();

        public List<BillInfo> GetBillInfoesInTable(int tableID)
        {
            Bill bill = billBUS.getBillByTableID(tableID);
            if (bill != null)
                return billInfoDAO.GetBillInfoesInBill(bill.ID);
            else return new List<BillInfo>();
        }
        public int getNewID()
        {
            return billInfoDAO.getNewID();
        }
        public void AddAmount(BillInfo bI, int amount, string note)
        {
            bI.Amount += amount;
            if (string.IsNullOrWhiteSpace(bI.Note))
                bI.Note = note;
            else
                bI.Note += ", " + note;
            billInfoDAO.Update(bI);
        }
        public void Add(BillInfo billInfo)
        {
            billInfoDAO.Add(billInfo);
        }
        public void Update(BillInfo billInfo)
        {
            billInfoDAO.Update(billInfo);
        }
        public void Delete(BillInfo billInfo)
        {
            billInfoDAO.Delete(billInfo);
        }
    }
}

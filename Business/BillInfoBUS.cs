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
        public void AddAmount(int bIID, int amnout, string note)
        {
            billInfoDAO.AddAmount(bIID, amnout, note);
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

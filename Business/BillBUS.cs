using Anh_Coffee.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.Business
{
    public class BillBUS
    {
        BillDAO billDAO = new BillDAO();
        TableDAO tableDAO = new TableDAO();
        public List<Bill> getBills()
        {
            return billDAO.getBills();
        }
        public int getNewID()
        {
            List<Bill> bills = billDAO.getBills();
            if (bills.Count == 0) return 1;
            else return bills.Last().ID + 1;
        }
        public Bill getBillByTableID(int tableID)
        {
            return billDAO.getBillByTableID(tableID);
        }
        public void swapTable(int oldTableID, int newTableID)
        {
            Bill b = getBillByTableID(oldTableID);
            b.TableID = newTableID;
            billDAO.Update(b);
        }
        public List<GetRevenue_Result> GetRevenue()
        {
            return billDAO.GetRevenue();
        }
        public void Add(Bill bill)
        {
            billDAO.Add(bill);
        }
        public void Update(Bill bill)
        {
            tableDAO.setTableStatus(bill.TableID, "Trống");
            billDAO.Update(bill);
        }
    }
}

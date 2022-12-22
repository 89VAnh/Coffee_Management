using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.Business
{
    public class BillBUS
    {
        BillDAO billDAO = new BillDAO();
        TableDAO tableDAO = new TableDAO();

        public void Add(Bill bill)
        {
            billDAO.Add(bill);
        }

        public Bill getBillIDByTableID(int tableID)
        {
            return billDAO.getBillByTableID(tableID);
        }

        public int getNewID()
        {
            return billDAO.getNewID();
        }

        public void Update(int oldTableID, int newTableID)
        {


            billDAO.UpdateTable(getBillIDByTableID(oldTableID).ID, newTableID);
        }
    }
}

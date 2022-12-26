using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class BillDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();

        public List<Bill> getBills()
        {
            return db.Bills.ToList();
        }

        public void swapTable(int billID, int tableID)
        {
            Bill b = db.Bills.Find(billID);
            b.TableID = tableID;
            db.GetRevenue();
            db.SaveChanges();
        }
        public List<GetRevenue_Result> GetRevenue()
        {
            return db.GetRevenue().ToList();
        }

        public void Add(Bill bill)
        {
            db.Bills.Add(bill);
            db.SaveChanges();
        }
        public void Update(Bill bill)
        {
            Bill b = db.Bills.Find(bill.ID);
            b.TableID = bill.TableID;
            b.Discount = bill.Discount;
            b.TotalPrice = bill.TotalPrice;
            b.CheckOut = bill.CheckOut;
            db.SaveChanges();
        }

    }
}

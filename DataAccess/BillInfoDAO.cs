using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class BillInfoDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();


        public List<BillInfo> GetBillInfoesInBill(int id)
        {
            return db.BillInfoes.Where(x => x.BillID == id).ToList();
        }

        public int getNewID()
        {
            if (db.BillInfoes.Count() == 0) return 1;
            else return db.BillInfoes.ToList().Last().ID + 1;
        }
        public void Add(BillInfo billInfo)
        {
            billInfo.Food = db.Foods.Find(billInfo.FoodID);
            db.BillInfoes.Add(billInfo);
            db.SaveChanges();
        }
        public void AddAmount(int id, int amount, string note)
        {
            BillInfo bI = db.BillInfoes.Find(id);
            bI.Amount += amount;
            bI.Note += note;
            db.SaveChanges();
        }

        public void Update(BillInfo billInfo)
        {
            BillInfo bI = db.BillInfoes.Find(billInfo.ID);
            bI.BillID = billInfo.BillID;
            bI.FoodID = billInfo.FoodID;
            bI.Amount = billInfo.Amount;
            bI.Note = billInfo.Note;
            db.SaveChanges();
        }
        public void Delete(BillInfo billInfo)
        {
            db.BillInfoes.Remove(billInfo);
            db.SaveChanges();
        }
    }
}

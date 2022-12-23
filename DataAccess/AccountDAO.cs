using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class AccountDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public Account getAccount(string un)
        {
            return db.Accounts.Find(un);
        }
        public Account getAccount(string un, string pw)
        {
            return db.Accounts.SingleOrDefault(a => a.UserName == un && a.Password == pw);
        }

        public string getStaffIDByUn(string un)
        {
            return db.Accounts.Find(un).StaffID;
        }

        public Account getAccountByStaffID(string staffID)
        {
            return db.Accounts.SingleOrDefault(x => x.StaffID == staffID);
        }
        public void Add(Account user)
        {
            db.Accounts.Add(user);
            db.SaveChanges();
        }
        public void Update(Account user)
        {
            Account u = db.Accounts.Find(user.UserName);
            u.Password = user.Password;
            db.SaveChanges();
        }

        public void Delete(Account user)
        {
            db.Accounts.Remove(user);
            db.SaveChanges();
        }
    }
}

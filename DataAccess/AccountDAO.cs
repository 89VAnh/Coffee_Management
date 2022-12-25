using System.Collections.Generic;
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

        public List<Account> getAccounts()
        {
            return db.Accounts.ToList();
        }
        public void Add(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }
        public void Update(Account account)
        {
            Account u = db.Accounts.Find(account.UserName);
            u.Password = account.Password;
            db.SaveChanges();
        }

        public void Delete(Account account)
        {
            db.Accounts.Remove(account);
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.DataAccess
{
    public class AccountDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public Account GetAccount(string un)
        {
            return db.Accounts.Find(un);
        }
        public Account GetAccount(string un, string pw)
        {
            return db.Accounts.SingleOrDefault(a => a.UserName == un && a.Password == pw);
        }

        public void Add(Account user)
        {
            db.Accounts.Add(user);
            db.SaveChanges();
        }
        public void Update(Account user)
        {
            Account u = db.Accounts.Find(user.UserName);
            u.UserName = user.UserName;
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

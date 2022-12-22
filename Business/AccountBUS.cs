using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anh_Coffee.DataAccess;

namespace Anh_Coffee.BUS
{
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        public static string currentAccount = "NV01";

        public Account GetAccount(string un)
        {
            return accountDAO.GetAccount(un);
        }
        public Account GetAccount(string un, string pw)
        {
            return accountDAO.GetAccount(un, pw);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anh_Coffee.DAO;

namespace Anh_Coffee.BUS
{
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        static private string currentAccount = "";
        public string CurrentAccount { get; set; }

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

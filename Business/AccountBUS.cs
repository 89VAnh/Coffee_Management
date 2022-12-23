using Anh_Coffee.DataAccess;

namespace Anh_Coffee.Business
{
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        public Account getAccount(string un)
        {
            return accountDAO.getAccount(un);
        }
        public Account getAccount(string un, string pw)
        {
            return accountDAO.getAccount(un, pw);
        }
        public string getStaffIDByUn(string un)
        {
            return accountDAO.getStaffIDByUn(un);
        }
        public Account getAccountByStaffID(string staffID)
        {
            return accountDAO.getAccountByStaffID(staffID);
        }

        public void Update(Account account)
        {
            accountDAO.Update(account);
        }
    }
}

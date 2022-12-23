using Anh_Coffee.DataAccess;
namespace Anh_Coffee.Business
{
    public class StaffBUS
    {
        StaffDAO staffDAO = new StaffDAO();
        AccountDAO accountDAO = new AccountDAO();
        public static string currentStaffID = "NV01";
        public Staff getStaffByID(string id)
        {
            return staffDAO.getStaffByID(id);
        }
        public void Update(Staff s)
        {
            staffDAO.Update(s);
        }
    }
}

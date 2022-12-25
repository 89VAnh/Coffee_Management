using Anh_Coffee.DataAccess;

namespace Anh_Coffee.Business
{
    public class StaffBUS
    {
        StaffDAO staffDAO = new StaffDAO();
        public static string currentStaffID = "NV01";

        public Staff getStaffByID(string id)
        {
            return staffDAO.getStaffByID(id);
        }
        public void Add(Staff staff)
        {
            staffDAO.Add(staff);
        }
        public void Update(Staff s)
        {
            staffDAO.Update(s);
        }
        public void Delete(Staff staff)
        {
            staffDAO.Delete(staff);
        }
    }
}

namespace Anh_Coffee.DataAccess
{
    public class StaffDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public Staff getStaffByID(string id)
        {
            return db.Staffs.Find(id);
        }
        public void Add(Staff staff)
        {
            db.Staffs.Add(staff);
            db.SaveChanges();
        }
        public void Update(Staff staff)
        {
            Staff s = db.Staffs.Find(staff.ID);
            s.Name = staff.Name;
            s.Phone = staff.Phone;
            s.Email = staff.Email;
            s.Address = staff.Address;
            s.PositionID = staff.PositionID;
            db.SaveChanges();
        }
        public void Delete(Staff staff)
        {
            db.Staffs.Remove(staff);
            db.SaveChanges();
        }
    }
}

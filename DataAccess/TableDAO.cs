using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class TableDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public List<TableCoffee> getTableCoffees()
        {
            return db.TableCoffees.ToList();
        }
        public void setTableStatus(int tableID, string status)
        {
            TableCoffee tb = db.TableCoffees.Find(tableID);
            if (status != tb.Status)
            {
                tb.Status = status;
                db.SaveChanges();
            }
        }
    }
}

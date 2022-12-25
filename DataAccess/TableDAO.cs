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
        public void Add(TableCoffee tableCoffee)
        {
            db.TableCoffees.Add(tableCoffee);
            db.SaveChanges();
        }

        public void Update(TableCoffee tableCoffee)
        {
            TableCoffee t = db.TableCoffees.Find(tableCoffee.ID);
            t.Name = tableCoffee.Name;
            db.SaveChanges();
        }
        public void Delete(TableCoffee tableCoffee)
        {
            db.TableCoffees.Remove(tableCoffee);
            db.SaveChanges();
        }
    }
}

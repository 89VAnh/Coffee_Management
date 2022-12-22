using Anh_Coffee.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public List<TableCoffee> getEmptyTable()
        {
            return db.TableCoffees.Where(x => x.Status == "Trống").ToList();
        }
    }
}

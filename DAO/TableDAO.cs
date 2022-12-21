using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.DAO
{
    public class TableDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public List<TableCoffee> GetTableCoffees()
        {
            return db.TableCoffees.ToList();
        }

    }
}

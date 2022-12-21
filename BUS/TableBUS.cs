using Anh_Coffee.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.BUS
{
    public class TableBUS
    {
        TableDAO tableDAO = new TableDAO();

        public List<TableCoffee> getTableCoffees()
        {
            return tableDAO.GetTableCoffees();
        }
    }
}

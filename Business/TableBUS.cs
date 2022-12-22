using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.Business
{
    public class TableBUS
    {
        TableDAO tableDAO = new TableDAO();
        List<TableCoffee> tableList = new List<TableCoffee>();

        public List<TableCoffee> getTableCoffees()
        {
            tableList = tableDAO.getTableCoffees();
            return tableList;
        }
        public void setTableStatus(int tableID, string status)
        {
            tableDAO.setTableStatus(tableID, status);
        }

        public List<TableCoffee> getEmptyTable()
        {
            return tableDAO.getEmptyTable();
        }
    }
}

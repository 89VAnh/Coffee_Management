using Anh_Coffee.DataAccess;
using System.Collections.Generic;

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

    }
}

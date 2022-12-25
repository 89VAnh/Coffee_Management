using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class PositionDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();

        public List<Position> getPositions()
        {
            return db.Positions.ToList();
        }
    }
}

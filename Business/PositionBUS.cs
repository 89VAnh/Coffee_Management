using Anh_Coffee.DataAccess;
using System.Collections.Generic;

namespace Anh_Coffee.Business
{
    public class PositionBUS
    {
        PositionDAO positionDAO = new PositionDAO();

        public List<Position> getPositions()
        {
            return positionDAO.getPositions();
        }
    }
}

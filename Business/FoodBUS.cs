using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.Business
{
    public class FoodBUS
    {
        FoodDAO foodDAO = new FoodDAO();

        public List<Food> getFoods()
        {
            return foodDAO.getFoods();
        }
        public List<Food> getFoodsByCategory(int categoryID)
        {
            return foodDAO.getFoodsByCategory(categoryID);
        }
    }
}

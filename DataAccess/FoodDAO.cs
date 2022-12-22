using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.DataAccess
{
    public class FoodDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public List<Food> getFoods()
        {
            return db.Foods.ToList();
        }
        public List<Food> getFoodsByCategory(int categoryID)
        {
            return db.Foods.Where(f => f.CategoryID == categoryID).ToList();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Anh_Coffee.DataAccess
{
    public class CategoryFoodDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();

        public List<CategoryFood> getCategoryFoods()
        {
            return db.CategoryFoods.ToList();
        }
    }
}

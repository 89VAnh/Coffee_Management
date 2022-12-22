using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

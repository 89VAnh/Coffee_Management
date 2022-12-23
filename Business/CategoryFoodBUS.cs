using Anh_Coffee.DataAccess;
using System.Collections.Generic;

namespace Anh_Coffee.Business
{
    public class CategoryFoodBUS
    {
        CategoryFoodDAO categoryFoodDAO = new CategoryFoodDAO();

        public List<CategoryFood> getCategoryFoods()
        {
            return categoryFoodDAO.getCategoryFoods();
        }
    }
}

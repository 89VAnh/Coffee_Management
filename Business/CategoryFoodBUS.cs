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
        public void Add(CategoryFood categoryFood)
        {
            categoryFoodDAO.Add(categoryFood);
        }
        public void Update(CategoryFood categoryFood)
        {
            categoryFoodDAO.Update(categoryFood);
        }
        public void Delete(CategoryFood categoryFood)
        {
            categoryFoodDAO.Delete(categoryFood);
        }
    }
}

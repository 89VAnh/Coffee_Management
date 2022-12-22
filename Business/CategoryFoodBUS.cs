using Anh_Coffee.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using Anh_Coffee.DataAccess;
using System.Collections.Generic;

namespace Anh_Coffee.Business
{
    public class FoodBUS
    {
        FoodDAO foodDAO = new FoodDAO();

        public List<Food> getFoods()
        {
            return foodDAO.getFoods();
        }

        public void Add(Food food)
        {
            foodDAO.Add(food);
        }
        public void Update(Food food)
        {
            foodDAO.Update(food);
        }
        public void Delete(Food food)
        {
            foodDAO.Delete(food);
        }
    }
}

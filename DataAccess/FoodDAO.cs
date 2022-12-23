using System.Collections.Generic;
using System.Linq;

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

        public void Add(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }
        public void Update(Food food)
        {
            Food f = db.Foods.Find(food.ID);
            f.Name = food.Name;
            f.CategoryID = food.CategoryID;
            f.Price = food.Price;
            db.SaveChanges();

        }
        public void Delete(Food food)
        {
            db.Foods.Remove(food);
            db.SaveChanges();
        }
    }
}

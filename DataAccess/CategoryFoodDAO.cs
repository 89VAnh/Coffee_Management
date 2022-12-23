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

        public void Add(CategoryFood categoryFood)
        {
            db.CategoryFoods.Add(categoryFood);
            db.SaveChanges();
        }

        public void Update(CategoryFood categoryFood)
        {
            CategoryFood cF = db.CategoryFoods.Find(categoryFood.ID);
            cF.Name = categoryFood.Name;
            db.SaveChanges();
        }
        public void Delete(CategoryFood categoryFood)
        {
            db.CategoryFoods.Remove(categoryFood);
            db.SaveChanges();
        }
    }
}

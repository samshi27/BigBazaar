using BigBazaar.Database;
using BigBazaar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BigBazaar.Services
{
    public class CategoriesServices
    {
        public Category GetCategory(int ID)
        {
            using (var context = new BBContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new BBContext())
            {
                return context.Categories.ToList();
            }
        }

        public void SaveCategory(Category category)
        {
            using (var context = new BBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        
        public void UpdateCategory(Category category)
        {
            using (var context = new BBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        public void DeleteCategory(int ID)
        {
            using (var context = new BBContext())
            {
                var category = context.Categories.Find(ID);

                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}

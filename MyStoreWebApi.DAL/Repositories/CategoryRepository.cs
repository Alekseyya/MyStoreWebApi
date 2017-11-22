using System;
using System.Data.Entity;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly MyStoreContext _context;
        public CategoryRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(Category item)
        {
            _context.Categories.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {

            Category category = _context.Categories.FirstOrDefault(o => o.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories.AsQueryable();
        }

        public Category GetItemById(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
                return category;
            else
            {
                return null;
            }
        }

        public void Update(Category item)
        {
            var category = _context.Categories.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (category.Name != item.Name)
            {
                category.Name = item.Name;
                isModified = true;
            }
            
            if (isModified)
            {
                _context.Entry(category).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

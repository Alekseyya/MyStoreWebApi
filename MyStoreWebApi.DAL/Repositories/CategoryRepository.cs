using System;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}

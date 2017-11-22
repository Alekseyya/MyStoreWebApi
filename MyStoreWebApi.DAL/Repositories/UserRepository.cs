using System;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly MyStoreContext _context;
        public UserRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}

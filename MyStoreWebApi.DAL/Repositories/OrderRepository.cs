using System;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly MyStoreContext _context;
        public OrderRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(Order item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Data.Entity;
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
            _context.Orders.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderList = _context.Orders.Where(o => o.Id == id);
            if (orderList != null)
            {
                foreach (var order in orderList)
                {
                    _context.Orders.Remove(order);
                }
                _context.SaveChanges();
            }
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.Include("Products").Include("User").AsQueryable();
        }

        public Order GetItemById(int id)
        {
            var order = _context.Orders.Include("Products").Include("User").FirstOrDefault(x => x.Id == id);
            if (order != null)
                return order;
            else
            {
                return null;
            }
        }

        public void Update(Order item)
        {
            var order = _context.Orders.Include("Products").Include("User").FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (order.OrderDate != item.OrderDate)
            {
                order.OrderDate = item.OrderDate;
                isModified = true;
            }

            if (order.OrderPrice != item.OrderPrice)
            {
                order.OrderPrice = item.OrderPrice;
                isModified = true;
            }

            if (order.Quantity != item.Quantity)
            {
                order.Quantity = item.Quantity;
                isModified = true;
            }

            //Просмотреть в дебаге как будет обарабатываться изменение продуктов заказе
            //Придется дописать
            if (order.Products.Count != item.Products.Count)
            {
                order.Products = item.Products;
                isModified = true;
            }

            if (isModified)
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(OrderDTO item)
        {
            var order = Mapper.Map<OrderDTO, Order>(item);
            _unitOfWork.OrderRepository.Create(order);
        }

        public void DeleteItem(OrderDTO item)
        {
            var user = Mapper.Map<UserDTO, User>(item.User);
            var findOrder = _unitOfWork.OrderRepository.GetAll()
                .FirstOrDefault(or => or.User == user && or.OrderDate == item.OrderDate);
                
            if (findOrder != null)
            {
                _unitOfWork.OrderRepository.Delete(findOrder.Id);
            }
        }

        public void DeleteItemById(int id)
        {
            
        }

        public IList<OrderDTO> GetAll()
        {
            var order = Mapper.Map<IQueryable<Order>, IList<OrderDTO>>(_unitOfWork.OrderRepository.GetAll());
            return order;
        }

        public OrderDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(OrderDTO item)
        {
            var order = Mapper.Map<OrderDTO, Order>(item);
            _unitOfWork.OrderRepository.Update(order);
        }
    }
}

using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddOrder(Order order)
        {
            var newOrder = Mapper.Map<Order, OrderDTO>(order);
            _service.AddItem(newOrder);
        }

        [HttpPost]
        public void UpdateOrder(Order order)
        {
            var correntOrder = Mapper.Map<Order, OrderDTO>(order);
            _service.UpdateItem(correntOrder);
        }

        [HttpPost]
        public void DeleteOrder(Order order)
        {
            var deletedOrder = Mapper.Map<Order, OrderDTO>(order);
            _service.DeleteItem(deletedOrder);
        }


        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            var orders =
                Mapper.Map<IEnumerable<OrderDTO>, List<Order>>(_service.GetAll());
            return orders;
        }
    }
}

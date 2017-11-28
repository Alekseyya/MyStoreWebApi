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
        public void AddOrder(OrderViewModel orderViewModel)
        {
            var newOrder = Mapper.Map<OrderViewModel, OrderDTO>(orderViewModel);
            _service.AddItem(newOrder);
        }

        [HttpPost]
        public void UpdateOrder(OrderViewModel orderViewModel)
        {
            var correntOrder = Mapper.Map<OrderViewModel, OrderDTO>(orderViewModel);
            _service.UpdateItem(correntOrder);
        }

        [HttpPost]
        public void DeleteOrder(OrderViewModel orderViewModel)
        {
            var deletedOrder = Mapper.Map<OrderViewModel, OrderDTO>(orderViewModel);
            _service.DeleteItem(deletedOrder);
        }


        [HttpGet]
        public IEnumerable<OrderViewModel> GetOrders()
        {
            var orders =
                Mapper.Map<IEnumerable<OrderDTO>, List<OrderViewModel>>(_service.GetAll());
            return orders;
        }
    }
}

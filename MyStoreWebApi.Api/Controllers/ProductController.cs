using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;
using MyStoreWebApi.DAL.Repositories;

namespace MyWebAPI.Api.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        //public ProductController()
        //{
        //    _service = new ProductService(new UnitOfWork());
        //}
        // GET api/values
        public IEnumerable<Product> GetProducts()
        {
            var products =
                Mapper.Map<IEnumerable<ProductDTO>, List<Product>>(_service.GetAll());
            return products;
        }

        public IEnumerable<string> GetTest()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

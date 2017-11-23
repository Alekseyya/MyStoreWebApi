using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            var newProduct = Mapper.Map<Product, ProductDTO>(product);
            _service.AddItem(newProduct);
        }

        [HttpPost]
        public void UpdateProduct(Product product)
        {
            var correctProduct = Mapper.Map<Product, ProductDTO>(product);
            _service.UpdateItem(correctProduct);
        }

        [HttpPost]
        public void DeleteProduct(Product product)
        {
            var deletedProduct = Mapper.Map<Product, ProductDTO>(product);
            _service.DeleteItem(deletedProduct);
        }


        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products =
                Mapper.Map<IEnumerable<ProductDTO>, List<Product>>(_service.GetAll());
            return products;
        }
        
    }
}

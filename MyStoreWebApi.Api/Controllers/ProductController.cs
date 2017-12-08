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
using MyWebAPI.Api.Helpers;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    //[Authorize]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddProduct(ProductViewModel productViewModel)
        {
            var newProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _service.AddItem(newProduct);
        }

        [HttpPost]
        public void UpdateProduct(ProductViewModel productViewModel)
        {
            var correctProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _service.UpdateItem(correctProduct);
        }

        [HttpPost]
        public void DeleteProduct(ProductViewModel productViewModel)
        {
            var deletedProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _service.DeleteItem(deletedProduct);
        }


        [HttpGet]
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var products =
                Mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(_service.GetAll());
            foreach (var product in products)
            {
                foreach (var picture in product.Pictures)
                {
                    picture.ImageBase64 =
                        Convert.ToBase64String(ConverterImage.ConvertImageToBiteArray(picture.ImageBase64));
                }
            }
            return products;
        }

        [HttpGet]
        public HttpResponseMessage GetRes()
        {
            var response = Request.CreateResponse<string>(HttpStatusCode.OK, "asda");
            return response;
        }

        [HttpPost]
        public void TestMethod([FromBody] string hello)
        {
            
        }
        
    }
}

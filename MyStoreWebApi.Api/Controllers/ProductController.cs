using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Helpers;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    //[Authorize]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public void AddProduct(ProductViewModel productViewModel)
        {
            var newProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _productService.AddItem(newProduct);
        }

        [HttpPost]
        public void UpdateProduct(ProductViewModel productViewModel)
        {
            var correctProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _productService.UpdateItem(correctProduct);
        }

        [HttpPost]
        public void DeleteProduct(ProductViewModel productViewModel)
        {
            var deletedProduct = Mapper.Map<ProductViewModel, ProductDTO>(productViewModel);
            _productService.DeleteItem(deletedProduct);
        }


        [HttpGet]
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var products =
                Mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(_productService.GetAll());
            var productsWithImages = SetPicture(products);
            return productsWithImages;
        }

        [HttpGet]
        public ProductViewModel GetProductsById(int id)
        {
            var product = Mapper.Map<ProductDTO, ProductViewModel>(_productService.GetItemById(id));
            return product;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> GetProductsForCart([FromUri]int[] productsId)
        {
            var products =
                Mapper.Map<IList<ProductDTO>, IEnumerable<ProductViewModel>>(_productService.GetProducts(productsId));
            return products;
        }


        [HttpGet]
        public HttpResponseMessage GetRes()
        {
            var response = Request.CreateResponse<string>(HttpStatusCode.OK, "asda");
            return response;
        }


        public class FastInputModel
        {
            public string Hello { get; set; }
        }

        [NonAction]
        public IEnumerable<ProductViewModel> SetPicture(IEnumerable<ProductViewModel> products)
        {
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

        //[HttpGet]
        //public IEnumerable<ProductViewModel> GetProducts(IEnumerable<ProductViewModel> products)
        //{
        //    var productsInDb = Mapper.Map<IEnumerable<ProductViewModel>, IEnumerable<ProductDTO>>(products);
        //    var resultProducts = Mapper.Map<IEnumerable<ProductDTO>, IEnumerable<ProductViewModel>>
        //        (_productService.GetProducts(productsInDb));

        //    return resultProducts;
        //}

        [HttpPost]
        public void TestMethod(object hello)
        {
           
        }
        
    }
}

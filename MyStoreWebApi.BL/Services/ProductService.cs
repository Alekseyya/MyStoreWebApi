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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(ProductDTO item)
        {
            var product = Mapper.Map<ProductDTO, Product>(item);
            _unitOfWork.ProductRepository.Create(product);
        }

        public void DeleteItem(ProductDTO item)
        {
            var product = Mapper.Map<ProductDTO, Product>(item);
            var findProduct = _unitOfWork.ProductRepository.GetAll()
                .FirstOrDefault(pr => pr.Name == item.Name);

            if (findProduct != null)
            {
                _unitOfWork.ProductRepository.Delete(findProduct.Id);
            }
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProductDTO> GetAll()
        {
            var product = Mapper.Map<IQueryable<Product>, IList<ProductDTO>>(_unitOfWork.ProductRepository.GetAll());
            return product;
        }

        public ProductDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(ProductDTO item)
        {
            var product = Mapper.Map<ProductDTO, Product>(item);
            _unitOfWork.ProductRepository.Update(product);
        }
    }
}

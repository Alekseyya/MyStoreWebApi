using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly MyStoreContext _context;
        public ProductRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(o => o.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public IList<Product> ListGetAll()
        {
            return _context.Products.Include("Orders")
                .Include("Category").Include("Pictures").Include("Mark").ToList();
        }

        public Product GetItemById(int id)
        {
            var product = _context.Products
                        .Include("Orders")
                        .Include("Photo")
                        .Include("Category")
                        .Include("Pictures")
                        .FirstOrDefault(x => x.Id == id);
            if (product != null)
                return product;
            else
            {
                return null;
            }
        }

        public void Update(Product item)
        {
            var product = _context.Products.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (product.Name != item.Name)
            {
                product.Name = item.Name;
                isModified = true;
            }
            
            if (product.Descriptions != item.Descriptions)
            {
                product.Descriptions = item.Descriptions;
                isModified = true;
            }

            if (product.Price != item.Price)
            {
                product.Price = item.Price;
                isModified = true;
            }

            if (product.CategoryId != item.CategoryId)
            {
                product.CategoryId = item.CategoryId;
                isModified = true;
            }

            if (product.IsDeleted != item.IsDeleted)
            {
                product.IsDeleted = item.IsDeleted;
                isModified = true;
            }


            if (product.Count != item.Count)
            {
                product.Count = item.Count;
                isModified = true;
            }
            
            if (isModified)
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products.Include("Orders")
                .Include("Category").Include("Pictures").Include("Mark").AsQueryable();
        }
    }
}

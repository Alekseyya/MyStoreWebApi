using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(CategoryDTO item)
        {
            var category = Mapper.Map<CategoryDTO, Category>(item);
            _unitOfWork.CategoryRepository.Create(category);
        }

        public void DeleteItem(CategoryDTO item)
        {
            var category = Mapper.Map<CategoryDTO, Category>(item);
            var findCategory = _unitOfWork.CategoryRepository.GetAll()
                .FirstOrDefault(cat => cat.Name == item.Name);
                
            if (findCategory != null)
            {
                _unitOfWork.CategoryRepository.Delete(findCategory.Id);
            }
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CategoryDTO> GetAll()
        {
            var category = Mapper.Map<IQueryable<Category>, IList<CategoryDTO>>(_unitOfWork.CategoryRepository.GetAll());
            return category;
        }

        public CategoryDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(CategoryDTO item)
        {
            var category = Mapper.Map<CategoryDTO, Category>(item);
            _unitOfWork.CategoryRepository.Update(category);
        }
    }
}

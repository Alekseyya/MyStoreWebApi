using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public void AddCategory(CategoryViewModel category)
        {
            var newCategory= Mapper.Map<CategoryViewModel, CategoryDTO>(category);
            _categoryService.AddItem(newCategory);
        }

        [HttpPost]
        public void UpdateCategory(CategoryViewModel category)
        {
            var updateCategory = Mapper.Map<CategoryViewModel, CategoryDTO>(category);
            _categoryService.UpdateItem(updateCategory);
        }

        [HttpPost]
        public void DeleteCategory(CategoryViewModel category)
        {
            var deletedCategory = Mapper.Map<CategoryViewModel, CategoryDTO>(category);
            _categoryService.DeleteItem(deletedCategory);
        }


        [HttpGet]
        public IEnumerable<CategoryViewModel> GetCategories()
        {
            var categories =
                Mapper.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(_categoryService.GetAll());
            return categories;
        }
    }
}

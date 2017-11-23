using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.MapperConfig
{
    public static class AutoMapperServiceConfiguration
    {
        public static void Configure()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new CategoryProfile());
            //});

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new OrderProfile());
            //});

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new PhotoProfile());
            //});

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new ProductProfile());
            //});

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile(new UserProfile());
            //});
        }
       
        public class CategoryProfile : Profile
        {
            public CategoryProfile()
            {
                CreateMap<CategoryDTO, Category>();
            }
        }

        public class OrderProfile : Profile
        {
            public OrderProfile()
            {
                CreateMap<OrderDTO, Order>();
            }
        }
        public class PhotoProfile : Profile
        {
            public PhotoProfile()
            {
                CreateMap<PhotoDTO, Photo>();
            }
        }
        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<ProductDTO, Product>();
            }
        }

        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<UserDTO, User>();
            }

        }

    }
}

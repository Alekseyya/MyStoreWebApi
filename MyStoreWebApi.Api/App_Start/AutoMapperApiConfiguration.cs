using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.MapperConfig;
using MyWebAPI.Api.Models;

namespace MyStoreWebApi.Api.App_Start
{
    public static class AutoMapperApiConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new UserWebApiProfile());
                cfg.AddProfile(new MarkWebApiProfile());
                cfg.AddProfile(new CategoryWebApiProfile());
                cfg.AddProfile(new ProductWebApiProfile());
                cfg.AddProfile(new PictureWebApiProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.CategoryProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.OrderProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.PictureProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.ProductProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.UserProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.MarkProfile());
            });
            
        }

        public class MarkWebApiProfile : Profile
        {
            public MarkWebApiProfile()
            {
                CreateMap<MarkDTO, MarkViewModel>();
                CreateMap<MarkViewModel, MarkDTO>();
            }

        }
        public class PictureWebApiProfile : Profile
        {
            public PictureWebApiProfile()
            {
                CreateMap<PictureDTO, PictureModel>();
            }

        }

        public class CategoryWebApiProfile : Profile
        {
            public CategoryWebApiProfile()
            {
                CreateMap<CategoryViewModel, CategoryDTO>();
            }

        }

        public class ProductWebApiProfile : Profile
        {
            public ProductWebApiProfile()
            {
                CreateMap<ProductViewModel, ProductDTO>();
            }

        }
        public class UserWebApiProfile : Profile
        {
            public UserWebApiProfile()
            {
                CreateMap<UserDTO, UserModel>();
                CreateMap<UserRegisterModel, UserDTO>();
                CreateMap<LoginModel, UserDTO>();
                CreateMap<UserModel, UserDTO>();
            }

        }
    }
}
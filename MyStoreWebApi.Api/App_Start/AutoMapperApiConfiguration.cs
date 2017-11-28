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
                cfg.AddProfile(new UserModelProfile());
                cfg.AddProfile(new UserWebApiProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.CategoryProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.OrderProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.PhotoProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.ProductProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.UserProfile());
            });
            
        }
        public class UserModelProfile : Profile
        {
            public UserModelProfile()
            {
                CreateMap<UserModel, UserDTO>();
            }

        }
        public class UserWebApiProfile : Profile
        {
            public UserWebApiProfile()
            {
                CreateMap<UserDTO, User>();
            }

        }
    }
}
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.MapperConfig;

namespace MyStoreWebApi.Api.App_Start
{
    public static class AutoMapperApiConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new ClientProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.CategoryProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.OrderProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.PhotoProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.ProductProfile());
                cfg.AddProfile(new AutoMapperServiceConfiguration.UserProfile());
            });
            
        }
        public class ClientProfile : Profile
        {
            public ClientProfile()
            {
                CreateMap<UserDTO, User>();
            }

        }
    }
}
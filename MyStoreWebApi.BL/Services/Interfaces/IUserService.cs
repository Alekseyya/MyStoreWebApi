using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Base;

namespace MyStoreWebApi.BL.Services.Interfaces
{
    public interface IUserService : IBaseService<UserDTO>
    {
        new bool AddItem(UserDTO user);
    }
}

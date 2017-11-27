using System;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories.Base
{
   public interface IUserRepository :IBaseRepository<User>
   {
        new bool Create(User user);
        void Delete(Guid guid);
        User FindByEmail(User user);
        void Delete(User user);
    }
}

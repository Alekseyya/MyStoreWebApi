using System;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories.Base
{
   public interface IUserRepository :IBaseRepository<User>
   {
       void Delete(Guid guid);
       User GetItemById(Guid guid);
   }
}

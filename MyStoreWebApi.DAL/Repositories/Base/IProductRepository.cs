using System.Collections.Generic;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories.Base
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        IList<Product> ListGetAll();
    }
}

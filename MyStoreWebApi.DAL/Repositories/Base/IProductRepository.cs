using System.Collections.Generic;
using System.Linq;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories.Base
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        IList<Product> ListGetAll();
        IQueryable<Product> GetAll(int[] arrayId);
    }
}

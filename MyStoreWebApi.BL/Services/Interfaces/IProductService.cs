using System.Collections.Generic;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Base;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Services.Interfaces
{
    public interface IProductService: IBaseService<ProductDTO>
    {
        IList<ProductDTO> GetProducts(int[] arrayId);
    }
}

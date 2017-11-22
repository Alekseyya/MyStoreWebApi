using System.Collections.Generic;

namespace MyStoreWebApi.BL.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        IList<T> GetAll();

        T GetItemById(int id);

        void AddItem(T item);

        void UpdateItem(T item);

        void DeleteItemById(int id);

        void DeleteItem(T item);
    }
}

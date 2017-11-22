using System.Linq;

namespace MyStoreWebApi.DAL.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetItemById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}

using System;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class PhotoRepository: IPhotoRepository
    {
        private readonly MyStoreContext _context;
        public PhotoRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(Photo item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Photo GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Photo item)
        {
            throw new NotImplementedException();
        }
    }
}

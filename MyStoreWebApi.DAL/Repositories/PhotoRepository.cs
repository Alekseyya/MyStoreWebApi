using System;
using System.Data.Entity;
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
            _context.Photos.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var photo = _context.Photos.FirstOrDefault(o => o.Id == id);
            if (photo != null)
            {
                _context.Photos.Remove(photo);
                _context.SaveChanges();
            }
        }

        public IQueryable<Photo> GetAll()
        {
            return _context.Photos.AsQueryable();
        }

        public Photo GetItemById(int id)
        {
            var photo = _context.Photos.FirstOrDefault(x => x.Id == id);
            if (photo != null)
                return photo;
            else
            {
                return null;
            }
        }

        public void Update(Photo item)
        {
            var photo = _context.Photos.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;
            
            if (photo.Image != photo.Image)
            {
                photo.Image = photo.Image;
                isModified = true;
            }

            if (isModified)
            {
                _context.Entry(photo).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

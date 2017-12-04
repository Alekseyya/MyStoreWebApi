using System;
using System.Data.Entity;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class PictureRepository: IPictureRepository
    {
        private readonly MyStoreContext _context;
        public PictureRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(Picture item)
        {
            _context.Pictures.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var photo = _context.Pictures.FirstOrDefault(o => o.Id == id);
            if (photo != null)
            {
                _context.Pictures.Remove(photo);
                _context.SaveChanges();
            }
        }

        public IQueryable<Picture> GetAll()
        {
            return _context.Pictures.Include("Product").AsQueryable();
        }

        public Picture GetItemById(int id)
        {
            var photo = _context.Pictures.Include("Product").FirstOrDefault(x => x.Id == id);
            if (photo != null)
                return photo;
            else
            {
                return null;
            }
        }

        public void Update(Picture item)
        {
            var photo = _context.Pictures.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (photo.Name != item.Name)
            {
                photo.Name = item.Name;
                isModified = true;
            }

            if (photo.Path != item.Path)
            {
                photo.Path = item.Path;
                isModified = true;
            }

            if (photo.UpdateTimestamp != item.UpdateTimestamp)
            {
                photo.Path = item.Path;
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

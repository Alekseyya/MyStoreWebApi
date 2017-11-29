using System;
using System.Data.Entity;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class MarkRepository : IMarkRepository
    {

        private readonly MyStoreContext _context;
        public MarkRepository(MyStoreContext context)
        {
            _context = context;
        }
        public void Create(Mark item)
        {
            _context.Marks.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Mark mark = _context.Marks.FirstOrDefault(o => o.Id == id);
            if (mark != null)
            {
                _context.Marks.Remove(mark);
                _context.SaveChanges();
            }
        }

        public IQueryable<Mark> GetAll()
        {
            return _context.Marks.Include("Products").AsQueryable();
        }

        public Mark GetItemById(int id)
        {
            var mark = _context.Marks.FirstOrDefault(x => x.Id == id);
            if (mark != null)
                return mark;
            else
            {
                return null;
            }
        }

        public void Update(Mark item)
        {
            var mark = _context.Marks.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (mark.Name != item.Name)
            {
                mark.Name = item.Name;
                isModified = true;
            }

            if (isModified)
            {
                _context.Entry(mark).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

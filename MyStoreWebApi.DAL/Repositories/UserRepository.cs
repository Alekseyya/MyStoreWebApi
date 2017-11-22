using System;
using System.Data.Entity;
using System.Linq;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly MyStoreContext _context;
        public UserRepository(MyStoreContext context)
        {
            _context = context;
        }

        public void Create(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Guid guid)
        {
            var user = _context.Users.FirstOrDefault(o => o.Id == guid);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.AsQueryable();
        }

        public User GetItemById(Guid guid)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == guid);
            if (user != null)
                return user;
            else
            {
                return null;
            }
        }

        public User GetItemById(int id)
        {
            return null;
        }

        public void Update(User item)
        {
            var user = _context.Users.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (user.Email != item.Email)
            {
                user.Email = item.Email;
                isModified = true;
            }
            if (user.EmailConfirmed != item.EmailConfirmed)
            {
                user.EmailConfirmed = item.EmailConfirmed;
                isModified = true;
            }
            if (user.PasswordHash != item.PasswordHash)
            {
                user.PasswordHash = item.PasswordHash;
                isModified = true;
            }
            if (user.SecurityStamp != item.SecurityStamp)
            {
                user.SecurityStamp = item.SecurityStamp;
                isModified = true;
            }
            if (user.PhoneNumber != item.PhoneNumber)
            {
                user.PhoneNumber = item.PhoneNumber;
                isModified = true;
            }
            if (user.PhoneNumberConfirmed != item.PhoneNumberConfirmed)
            {
                user.PhoneNumberConfirmed = item.PhoneNumberConfirmed;
                isModified = true;
            }
            if (user.TwoFactorEnabled != item.TwoFactorEnabled)
            {
                user.TwoFactorEnabled = item.TwoFactorEnabled;
                isModified = true;
            }
            if (user.LockoutEndDateUtc != item.LockoutEndDateUtc)
            {
                user.LockoutEndDateUtc = item.LockoutEndDateUtc;
                isModified = true;
            }
            if (user.LockoutEnabled != item.LockoutEnabled)
            {
                user.LockoutEnabled = item.LockoutEnabled;
                isModified = true;
            }
            if (user.AccessFailedCount != item.AccessFailedCount)
            {
                user.AccessFailedCount = item.AccessFailedCount;
                isModified = true;
            }
            if (user.UserName != item.UserName)
            {
                user.UserName = item.UserName;
                isModified = true;
            }
            if (isModified)
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

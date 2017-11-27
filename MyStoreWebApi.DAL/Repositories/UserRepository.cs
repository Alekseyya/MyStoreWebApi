using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DAL.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly MyStoreContext _context;
        private readonly UserManager<User,Guid> _userManager;
        public UserRepository(MyStoreContext context)
        {
            _context = context;
            _userManager = new UserManager<User,Guid>(new CustomUserStore(context));
        }

        //Register user
        public bool Create(User item)
        {
            var result = _userManager.Create(item, item.PasswordHash);
            //_context.Users.Add(item);
            _context.SaveChanges();
            if (result.Succeeded)
                return true;
            return false;
        }

        public User Find(User user)
        {
            var userFind = _userManager.Find(user.UserName, user.PasswordHash);
            if (userFind != null)
                return userFind;
            return null;
        }

        public void Delete(User user)
        {
            _userManager.Delete(user);
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

        public User FindByEmail(User user)
        {
            var userFind =  _userManager.FindByEmail(user.Email);
            return userFind;

        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.AsQueryable();
        }

        public User GetItemById(Guid guid)
        {
            //var user = _context.Users.FirstOrDefault(x => x.Id == guid);
            //if (user != null)
            //    return user;
            //else
            //{
            //    return null;
            //}
            return null;
        }

        public User GetItemById(int id)
        {
            return null;
        }

        void IBaseRepository<User>.Create(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            var userUpdate = _userManager.FindById(item.Id);

            bool isModified = false;

            if (userUpdate.Email != item.Email)
            {
                userUpdate.Email = item.Email;
                isModified = true;
            }
            if (userUpdate.EmailConfirmed != item.EmailConfirmed)
            {
                userUpdate.EmailConfirmed = item.EmailConfirmed;
                isModified = true;
            }
            if (userUpdate.PasswordHash != item.PasswordHash)
            {
                userUpdate.PasswordHash = item.PasswordHash;
                isModified = true;
            }
            if (userUpdate.SecurityStamp != item.SecurityStamp)
            {
                userUpdate.SecurityStamp = item.SecurityStamp;
                isModified = true;
            }
            if (userUpdate.PhoneNumber != item.PhoneNumber)
            {
                userUpdate.PhoneNumber = item.PhoneNumber;
                isModified = true;
            }
            if (userUpdate.PhoneNumberConfirmed != item.PhoneNumberConfirmed)
            {
                userUpdate.PhoneNumberConfirmed = item.PhoneNumberConfirmed;
                isModified = true;
            }
            if (userUpdate.TwoFactorEnabled != item.TwoFactorEnabled)
            {
                userUpdate.TwoFactorEnabled = item.TwoFactorEnabled;
                isModified = true;
            }
            if (userUpdate.LockoutEndDateUtc != item.LockoutEndDateUtc)
            {
                userUpdate.LockoutEndDateUtc = item.LockoutEndDateUtc;
                isModified = true;
            }
            if (userUpdate.LockoutEnabled != item.LockoutEnabled)
            {
                userUpdate.LockoutEnabled = item.LockoutEnabled;
                isModified = true;
            }
            if (userUpdate.AccessFailedCount != item.AccessFailedCount)
            {
                userUpdate.AccessFailedCount = item.AccessFailedCount;
                isModified = true;
            }
            if (userUpdate.UserName != item.UserName)
            {
                userUpdate.UserName = item.UserName;
                isModified = true;
            }
            if (isModified)
            {
                _userManager.Update(userUpdate);
                _context.SaveChanges();
            }
        }
    }
}

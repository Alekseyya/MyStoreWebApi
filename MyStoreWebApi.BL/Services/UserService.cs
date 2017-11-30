using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Base;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Services
{
    public class UserService : IUserService
    {
        //usermanager
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddItem(UserDTO item)
        {
            var user = Mapper.Map<UserDTO, User>(item);
            var result = _unitOfWork.UserRepository.Create(user);
            if (result)
                return true;
            return false;
        }

        public void DeleteItem(UserDTO item)
        {
            
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<UserDTO> GetAll()
        {
            var clients = Mapper.Map<IQueryable<User>, IList<UserDTO>>(_unitOfWork.UserRepository.GetAll());
            return clients;
        }

        public UserDTO GetItemById(int id)
        {
            return null;
        }

        public UserDTO FindUser(UserDTO user)
        {
            var userFind = Mapper.Map<UserDTO, User>(user);
            var findedUser = _unitOfWork.UserRepository.Find(userFind);
            if (findedUser != null)
            {
                return Mapper.Map<User, UserDTO>(findedUser);
            }
                
            return null;
        }

        public void UpdateItem(UserDTO item)
        {
            var user = Mapper.Map<UserDTO, User>(item);
            _unitOfWork.UserRepository.Update(user);
        }

        void IBaseService<UserDTO>.AddItem(UserDTO item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(UserDTO user)
        {
            var findUser = _unitOfWork.UserRepository.GetAll()
                .FirstOrDefault(us => us.UserName == user.UserName);
            if (findUser != null)
            {
                _unitOfWork.UserRepository.Delete(findUser.Id);
                return true;
            }
            return false;
        }

        void IBaseService<UserDTO>.DeleteItem(UserDTO item)
        {
            throw new NotImplementedException();
        }
    }
}

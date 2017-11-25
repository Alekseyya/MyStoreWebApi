using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyStoreWebApi.BL.Models;
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

        public void AddItem(UserDTO item)
        {
            var user = Mapper.Map<UserDTO, User>(item);
            _unitOfWork.UserRepository.Create(user);
        }

        public void DeleteItem(UserDTO item)
        {
            var findUser = _unitOfWork.UserRepository.GetAll()
                .FirstOrDefault(us => us.UserName == item.UserName);
            if (findUser != null)
            {
                _unitOfWork.UserRepository.Delete(findUser.Id);
            }
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

        public void UpdateItem(UserDTO item)
        {
            var user = Mapper.Map<UserDTO, User>(item);
            _unitOfWork.UserRepository.Update(user);
        }
    }
}

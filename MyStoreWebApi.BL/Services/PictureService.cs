using System;
using System.Collections.Generic;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories.Base;

namespace MyStoreWebApi.BL.Services
{
    public class PictureService : IPictureService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PictureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(PictureDTO item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(PictureDTO item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PictureDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PictureDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(PictureDTO item)
        {
            throw new NotImplementedException();
        }
    }
}

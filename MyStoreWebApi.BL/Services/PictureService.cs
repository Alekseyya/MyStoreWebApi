using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Entities;

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
            var picture = Mapper.Map<PictureDTO, Picture>(item);
            _unitOfWork.PictureRepository.Create(picture);
        }

        public void DeleteItem(PictureDTO item)
        {
            var picture = Mapper.Map<PictureDTO, Picture>(item);
            var findPicture = _unitOfWork.PictureRepository.GetAll()
                .FirstOrDefault(p=>p.Name == item.Name);

            if (findPicture != null)
            {
                _unitOfWork.PictureRepository.Delete(findPicture.Id);
            }
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PictureDTO> GetAll()
        {
            var pictures = Mapper.Map<IQueryable<Picture>, IList<PictureDTO>>(_unitOfWork.PictureRepository.GetAll());
            return pictures;
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

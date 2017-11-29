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
    public class MarkService : IMarkService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(MarkDTO item)
        {
            var mark = Mapper.Map<MarkDTO, Mark>(item);
            _unitOfWork.MarkRepository.Create(mark);
        }

        public void DeleteItem(MarkDTO item)
        {
            var mark = Mapper.Map<MarkDTO, Mark>(item);
            var findMark = _unitOfWork.MarkRepository.GetAll()
                .FirstOrDefault(mar => mar.Name == item.Name);

            if (findMark != null)
            {
                _unitOfWork.MarkRepository.Delete(findMark.Id);
            }
        }

        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<MarkDTO> GetAll()
        {
            var marks = Mapper.Map<IQueryable<Mark>, IList<MarkDTO>>(_unitOfWork.MarkRepository.GetAll());
            return marks;
        }

        public MarkDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(MarkDTO item)
        {
           var mark = Mapper.Map<MarkDTO, Mark>(item);
            _unitOfWork.MarkRepository.Update(mark);
        }
    }
}

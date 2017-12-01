using System;
using System.Web.Http;
using System.Web.Http.Cors;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using MyWebAPI.Api.Helpers;

namespace MyWebAPI.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PictureController : ApiController
    {
        private readonly IPictureService _pictureService;
        public PictureController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        [HttpGet]
        public IEnumerable<PictureViewModel> GetPictures()
        {
            var picturesDTO = _pictureService.GetAll();
            var listPictures = new List<PictureViewModel>();
            foreach (var picture in picturesDTO)
            {
                if (picture.Path != "")
                {
                    var imageByte = ConverterImage.ConvertImageToBiteArray(picture.Path);
                    listPictures.Add(new PictureViewModel()
                    {
                        Name = picture.Name,
                        ImageBase64 = Convert.ToBase64String(imageByte)
                    });
                }
            }
            return listPictures;
        }

        
    }
}

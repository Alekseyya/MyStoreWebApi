using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MarkController : ApiController
    {
        private readonly IMarkService _markService;
        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }
        [HttpPost]
        public void AddMark(MarkViewModel markViewModel)
        {
            var newMark = Mapper.Map<MarkViewModel, MarkDTO>(markViewModel);
            _markService.AddItem(newMark);
        }

        [HttpPost]
        public void UpdateMark(MarkViewModel markViewModel)
        {
            var correctMark= Mapper.Map<MarkViewModel, MarkDTO>(markViewModel);
            _markService.UpdateItem(correctMark);
        }

        [HttpPost]
        public void DeleteMark(MarkViewModel markViewModel)
        {
            var deletedMark = Mapper.Map<MarkViewModel, MarkDTO>(markViewModel);
            _markService.DeleteItem(deletedMark);
        }


        [HttpGet]
        public IEnumerable<MarkViewModel> GetMarks()
        {
            var marks =
                Mapper.Map<IEnumerable<MarkDTO>, List<MarkViewModel>>(_markService.GetAll());
            return marks;
        }
    }
}

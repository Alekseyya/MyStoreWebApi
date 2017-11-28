using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.App_Start;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IUserService _service;
        public AccountController(IUserService service)
        {
            
            _service = service;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            var users = Mapper.Map<IEnumerable<UserDTO>, List<User>>(_service.GetAll());
            return users;
        }

        [HttpPost]
        //[AllowAnonymous]
        //[Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // var result = UserManager.Create(user, userModel.Password); go to service
            var user = Mapper.Map<UserModel, UserDTO>(userModel);
            var resultAdd = _service.AddItem(user);

            if (!resultAdd)
            {
                return GetErrorResult();
            }

            return Ok();
        }
        

        private IHttpActionResult GetErrorResult()
        {
            //if (result == null)
            //{
            //    return InternalServerError();
            //}

            //if (!result)
            //{
            //    if (result.Errors != null)
            //    {
            //        foreach (string error in result.Errors)
            //        {
            //            ModelState.AddModelError("", error);
            //        }
            //    }

            //    if (ModelState.IsValid)
            //    {
            //        // No ModelState errors are available to send, so just return an empty BadRequest.
            //        return BadRequest();
            //    }

            //    return BadRequest(ModelState);
            //}
            return null;
        }
    }
}

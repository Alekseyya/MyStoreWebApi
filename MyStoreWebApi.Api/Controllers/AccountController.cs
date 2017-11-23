using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using Microsoft.AspNet.Identity;
using MyStoreWebApi.Api.Models;
using MyStoreWebApi.BL.Models;
using MyStoreWebApi.BL.Services.Interfaces;
using MyWebAPI.Api.Models;

namespace MyWebAPI.Api.Controllers
{
    public class AccountController : ApiController
    {
        private AuthRepository _repo = null;
        private readonly IUserService _service;

        public AccountController(IUserService service)
        {
            _repo = new AuthRepository();
            _service = service;
        }


        [HttpPost]
        public void AddUser(UserModel user)
        {
            var aa = 0;
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
            
            IdentityResult result = await _repo.RegisterUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}

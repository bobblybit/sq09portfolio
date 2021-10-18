using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using portfolio.Common;
using portfolio.Data.Dto;
using portfolio.Data.Repository.Interface;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetUserById([FromHeader]string userId)
        {

            if (String.IsNullOrEmpty(userId))
            {
                return BadRequest(Utilities.CreateResponse<UserToReturnDTO>("User Id cannot be empty", null));
            }

            User userFromDb = _userService.GetUserAsync(userId);


            if (userFromDb == null)
            {
                return Unauthorized(Utilities.CreateResponse<UserToReturnDTO>("Provided Id is not registered", null));
            }

            var userToReturn = _mapper.Map<UserToReturnDTO>(userFromDb);

            return Ok(Utilities.CreateResponse<UserToReturnDTO>("User was successfully retrieved", userToReturn));

        }
    }
}

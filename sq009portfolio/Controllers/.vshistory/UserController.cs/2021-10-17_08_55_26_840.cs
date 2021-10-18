using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public  UserToReturnDTO GetUserById([FromHeader]string userId)
        {
            User userFromDb = _userService.GetUserAsync(userId);

            var userToReturn = _mapper.Map<UserToReturnDTO>(User);

            return userToReturn;

        }
    }
}

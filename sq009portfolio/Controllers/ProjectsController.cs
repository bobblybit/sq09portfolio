using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using portfolio.Models;
using System.Net.Http;
using System.Web;
using portfolio.Data.Dto;
using portfolio.Common;

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Projects> getProjects([FromHeader] string userId)
        {
            List<Projects> userProjects = new List<Projects>();

            return userProjects;


        }
    }
}

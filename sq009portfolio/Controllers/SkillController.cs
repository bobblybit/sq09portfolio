using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Skill> GetSkills([FromHeader] string UserId)
        {
            List<Skill> userSkills = new List<Skill>();
            return userSkills;
        }

    }
}

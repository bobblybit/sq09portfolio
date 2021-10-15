using portfolio.Data.Repository.Interface;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Repository.Implementation
{
    public class SkillService : ISkill
    {
        public IEnumerable<Skill> GetSkilsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

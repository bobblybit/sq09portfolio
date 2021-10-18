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

        private readonly PortfolioContext _ctx;

        public SkillService(PortfolioContext ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<Skill> GetSkilsAsync(string userId)
        {
            return _ctx.Skills.FirstOrDefault(x => x.UserId == userId);
        }
    }
}

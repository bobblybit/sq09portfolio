using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Dto
{
    public class UserToReturn
    {
        public User User { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Projects> Projects { get; set; }
    }
}

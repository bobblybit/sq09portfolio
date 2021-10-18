using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Proficiency { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }
}

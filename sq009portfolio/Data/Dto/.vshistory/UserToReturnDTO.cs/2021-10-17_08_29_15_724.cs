using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Dto
{
    public class UserToReturn
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public Contact ContactInfo { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Projects> Projects { get; set; }
    }
}

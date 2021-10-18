using portfolio.Data.Models;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Dto
{
    public class UserToReturnDTO
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public ContactToReturnDTO ContactInfo { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Projects> Projects { get; set; }
    }
}

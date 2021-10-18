using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SocialMedia { get; set; }
        public string LinkedIn { get; set; }
        public string Github { get; set; }

    }
}

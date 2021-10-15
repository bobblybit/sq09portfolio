using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImgURL { get; set; }
        public string TechnologiesUsed { get; set; }
        public string GitHubUrl { get; set; }
    }
}

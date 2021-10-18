using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Dto
{
    public class ProjectToReturnDTO
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImgURL { get; set; }
        public string TechnologiesUsed { get; set; }
        public string GitHubUrl { get; set; }
        public string LinkToLivedemo { get; set; }
    }
}

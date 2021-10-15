using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Repository.Interface
{
    public interface IProject
    {
        public IEnumerable<Projects> GetProjectsAsync();
    }
}

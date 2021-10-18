using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Repository.Interface
{
    public interface IUserService
    {
        public User GetUserAsync(string UserId);
    }
}

using portfolio.Data.Repository.Interface;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Repository.Implementation
{
    public class UserService : IUserService
    {
        private readonly PortfolioContext _ctx;

        public UserService(PortfolioContext ctx)
        {
            _ctx = ctx;
        }

        public User GetUserAsync(string UserId)
        {
            
        }
    }
}

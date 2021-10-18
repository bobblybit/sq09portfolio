using portfolio.Data.Repository.Interface;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace portfolio.Data.Repository.Implementation
{
    public class UserService : IUserService
    {
        private readonly PortfolioContext _ctx;

        public UserService(PortfolioContext ctx)
        {
            _ctx = ctx;
        }

        public User GetUserAsync(string UserId) => _ctx.Users
                                                   .Include(x => x.Projects)
                                                   .Include(x => x.Skills)
                                                   .Include(x => x.ContactInfo)
                                                   .FirstOrDefault(x => x.UserId == UserId);

    }
}

using Microsoft.EntityFrameworkCore;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data
{
    public class PortfolioContext : DbContext
    {

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }

    }
}

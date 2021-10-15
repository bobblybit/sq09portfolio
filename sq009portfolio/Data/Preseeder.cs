using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using portfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace portfolio.Data
{
    public static class Preseeder
    {
        private static readonly string path = Path.GetFullPath(@"Data/json-data/");

        public static async Task Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<PortfolioContext>();
            context.Database.EnsureCreated();


            if (!context.Users.Any())
            {
                var userData = GetSeedData<User>(File.ReadAllText(path + "User.json"));
                await context.Users.AddRangeAsync(userData);
                await context.SaveChangesAsync();
            }



            if (!context.Skills.Any())
            {
                var skills = GetSeedData<Skill>(File.ReadAllText(path + "skills.json"));
                await context.Skills.AddRangeAsync(skills);
                await context.SaveChangesAsync();
            }


            if (!context.Projects.Any())
            {
                var projects = GetSeedData<Projects>(File.ReadAllText(path + "projects.json"));
                await context.Projects.AddRangeAsync(projects);
                await context.SaveChangesAsync();
            }



        }

        private static List<T> GetSeedData<T>(string location)
        {
            var output = JsonSerializer.Deserialize<List<T>>(location, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return output;
        }
    }
}

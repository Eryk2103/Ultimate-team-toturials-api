using Microsoft.EntityFrameworkCore;
using UltimateTeamApi.Data.Models;

namespace UltimateTeamApi.Data
{
    public class AppDbContext : DbContext
    {
#pragma warning disable CS8618 
        public AppDbContext(DbContextOptions opt) : base(opt)
#pragma warning restore CS8618 
        {

        }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Tag> Tags { get; set; }
        }
}

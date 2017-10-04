using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AlexisAtchison.Models;

namespace AlexisAtchison.Data
{
    public class MyContext : DbContext
    {
        private IConfigurationRoot _config;

        public MyContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<PropertyListing> PropertyListings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:AlexisAtchisonContextConnectionWin"]);
        }
    }
}

using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Infrastructure.Extensions;

namespace Infrastructure.Data
{
    public class CharacterCollectionContext : DbContext
    {
        private readonly IConfiguration configuration;
        public CharacterCollectionContext(DbContextOptions<CharacterCollectionContext> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Villain> Villian { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CharacterCollectionDatabase"));
        }
    }
}

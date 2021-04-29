using Microsoft.EntityFrameworkCore;

namespace PaperFactory.Data
{
    class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=wsr_factory;Trusted_Connection=True;");
        }

        public DbSet<UsersInfo> UsersInfos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}

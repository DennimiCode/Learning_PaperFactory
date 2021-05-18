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
            // DESKTOP-0CN3VVB
            // DENIS-PC
            optionsBuilder.UseSqlServer(@"Server=DENIS-PC;Database=wsr_factory;Trusted_Connection=True;");
        }

        public DbSet<UsersInfo> UsersInfo { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Metrics> Metrics { get; set; }
        public DbSet<MaterialsTypes> MaterialsTypes { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
    }
}

using NonoGame.Model;
using Microsoft.EntityFrameworkCore;

namespace NonoGame.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Nonogram> Nonogram { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            SeedImages(builder);
        }

        void SeedImages(ModelBuilder builder)
        {
            builder.Entity<Nonogram>().HasData(
                new Nonogram
                {
                    Id = 1,
                    Size = 5,
                    Image = "0;1;1;1;0;0;0;0;1;1;1;1;1;1;1;1;1;0;0;0;0;1;1;1;0",
                    Date = DateTime.Now,
                },
                new Nonogram
                {
                    Id = 2,
                    Size = 5,
                    Image = "1;1;1;1;0;0;1;0;0;0;0;1;1;0;0;0;1;0;0;1;1;1;1;1;0",
                    Date = DateTime.Now,
                },
                new Nonogram
                {
                    Id = 3,
                    Size = 5,
                    Image = "0;1;1;1;1;0;1;0;0;1;0;1;0;0;1;1;1;0;1;1;1;1;0;1;1",
                    Date = DateTime.Now,
                },
                new Nonogram
                {
                    Id = 4,
                    Size = 7,
                    Image = "1;0;0;1;0;0;1;0;1;1;1;1;1;0;0;1;0;0;0;1;0;0;1;0;1;0;1;0;0;1;0;0;0;1;0;0;1;1;1;1;1;0;1;0;0;1;0;0;1",
                    Date = DateTime.Now,
                },
                new Nonogram
                {
                    Id = 5,
                    Size = 5,
                    Image = "0;0;1;0;0;0;0;1;0;0;1;1;1;1;1;0;1;1;1;0;1;0;0;0;1",
                    Date = DateTime.Now,
                }
            );
        }
    }
}

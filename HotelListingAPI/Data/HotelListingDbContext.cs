using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="India",
                    ShortName="IND"
                },
                new Country
                {
                    Id = 2,
                    Name = "China",
                    ShortName = "CHI"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel Taj",
                    Address = "Mumbai Near Beach",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Krishan Hotel",
                    Address = "Sjbub  Jnj45 nknn,china",
                    CountryId = 2,
                    Rating = 4.2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel American spice",
                    Address = "ns 34 insknd ian",
                    CountryId = 3,
                    Rating = 4.0
                }) ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel_API.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<CountryModel> Country { get; set; }

        public DbSet<HotelModel> Hotel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CountryModel>().HasData(
                new CountryModel
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                }, new CountryModel
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                }, new CountryModel
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );
            builder.Entity<HotelModel>().HasData(
                new HotelModel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                }, new HotelModel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                }, new HotelModel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 4
                }
            );
        }
    }
}
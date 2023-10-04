using Microsoft.EntityFrameworkCore;
using Salmon_Cookie_Application_API.Models;

namespace Salmon_Cookie_Application_API.Data
{
    public class CookieDBContext : DbContext
    {
        public CookieDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CookieStand> Cookies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CookieStand>().HasData(
                new CookieStand
                {
                    ID = 1,
                    Location = "Zarqa",
                    Description = "Since 1995",
                    MaximumCustomerPerHour = 10,
                    MinimumCustomerPerHour = 3,
                    AverageCookiesPerSale = 2.50,
                    Owner = "Ahmad Mohsen"
                }
                );

            modelBuilder.Entity<HourlySale>().HasData(
                new HourlySale
                {
                    ID = 1,
                    CookieStandID = 1,
                    SalePerHour = 10,
                },
                new HourlySale
                {
                    ID = 2,
                    CookieStandID = 1,
                    SalePerHour = 15,
                },
                new HourlySale
                {
                    ID = 3,
                    CookieStandID = 1,
                    SalePerHour = 12,
                },
                new HourlySale
                {
                    ID = 4,
                    CookieStandID = 1,
                    SalePerHour = 18,
                },
                new HourlySale
                {
                    ID = 5,
                    CookieStandID = 1,
                    SalePerHour = 25,
                },
                new HourlySale
                {
                    ID = 6,
                    CookieStandID = 1,
                    SalePerHour = 12,
                },
                new HourlySale
                {
                    ID = 7,
                    CookieStandID = 1,
                    SalePerHour = 30,
                },
                new HourlySale
                {
                    ID = 8,
                    CookieStandID = 1,
                    SalePerHour = 23,
                },
                new HourlySale
                {
                    ID = 9,
                    CookieStandID = 1,
                    SalePerHour = 9,
                },
                new HourlySale
                {
                    ID = 10,
                    CookieStandID = 1,
                    SalePerHour = 14,
                },
                new HourlySale
                {
                    ID = 11,
                    CookieStandID = 1,
                    SalePerHour = 17,
                },
                new HourlySale
                {
                    ID = 12,
                    CookieStandID = 1,
                    SalePerHour = 11,
                },
                new HourlySale
                {
                    ID = 13,
                    CookieStandID = 1,
                    SalePerHour = 19,
                },
                new HourlySale
                {
                    ID = 14,
                    CookieStandID = 1,
                    SalePerHour = 5,
                }

                );
        }
    }
}

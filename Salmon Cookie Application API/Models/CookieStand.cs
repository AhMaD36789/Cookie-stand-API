using Salmon_Cookie_Application_API.Models.DTOs;

namespace Salmon_Cookie_Application_API.Models
{
    public class CookieStand
    {
        public int ID { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public List<HourlySale>? HourlySales { get; set; }
        public string Description { get; set; }
        public int MinimumCustomerPerHour { get; set; }
        public int MaximumCustomerPerHour { get; set; }
        public double AverageCookiesPerSale { get; set; }
        public string? Owner { get; set; }

        public static explicit operator CookieStand(CookieStandDTO dto)
        {
            return new CookieStand
            {
                ID = dto.ID,
                Location = dto.Location,
                Description = dto.Description,
                MinimumCustomerPerHour = dto.MinimumCustomerPerHour,
                MaximumCustomerPerHour = dto.MaximumCustomerPerHour,
                AverageCookiesPerSale = dto.AverageCookiesPerSale,
                Owner = dto.Owner
            };
        }

    }
}

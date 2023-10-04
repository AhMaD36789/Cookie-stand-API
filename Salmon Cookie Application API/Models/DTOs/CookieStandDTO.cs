namespace Salmon_Cookie_Application_API.Models.DTOs
{
    public class CookieStandDTO
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int MinimumCustomerPerHour { get; set; }
        public int MaximumCustomerPerHour { get; set; }
        public double AverageCookiesPerSale { get; set; }
        public string? Owner { get; set; }
    }

    public class CookieStandGetDTO
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public List<int>? HourlySales { get; set; }
        public string Description { get; set; }
        public int MinimumCustomerPerHour { get; set; }
        public int MaximumCustomerPerHour { get; set; }
        public double AverageCookiesPerSale { get; set; }
        public string? Owner { get; set; }

        public static explicit operator CookieStandGetDTO(CookieStand cookieStand)
        {
            var y = new List<int>();
            foreach (var item in cookieStand.HourlySales)
            {
                y.Add(item.SalePerHour);
            }
            var x = new CookieStandGetDTO
            {
                ID = cookieStand.ID,
                Location = cookieStand.Location,
                Description = cookieStand.Description,
                HourlySales = y,
                AverageCookiesPerSale = cookieStand.AverageCookiesPerSale,
                MaximumCustomerPerHour = cookieStand.MaximumCustomerPerHour,
                MinimumCustomerPerHour = cookieStand.MinimumCustomerPerHour,
                Owner = cookieStand.Owner
            };
            return x;
        }
    }

}




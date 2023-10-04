namespace Salmon_Cookie_Application_API.Models.DTOs
{
    public class HourlySalesDTO
    {
        public int ID { get; set; }
        public int CookieStandID { get; set; }
        public int SalePerHour { get; set; }
    }

    public class HourlySalesGetDTO
    {
        public int salePerHour { get; set; }
    }
}

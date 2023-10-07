namespace Salmon_Cookie_Application_API.Models
{
    public class HourlySale
    {
        public int ID { get; set; }
        public int CookieStandID { get; set; }
        public int SalePerHour { get; set; }
        public int CustomerPerHour { get; set; }

        //Navigation Property
        public CookieStand? CookieStand { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Salmon_Cookie_Application_API.Data;
using Salmon_Cookie_Application_API.Models.DTOs;

namespace Salmon_Cookie_Application_API.Models.Services
{
    public class CookieStandService : ICookieStandService
    {
        private readonly CookieDBContext _context;

        public CookieStandService(CookieDBContext context)
        {
            _context = context;
        }

        public async Task<CookieStandGetDTO> PostCookieStand(CookieStand cookieStand)
        {
            try
            {
                var random = new Random();
                cookieStand.HourlySales = new List<HourlySale>();
                for (int i = 0; i < 14; i++)
                {
                    int customersPerHour = random.Next(cookieStand.MinimumCustomerPerHour, cookieStand.MaximumCustomerPerHour + 1);
                    int cookiesSold = (int)Math.Round(customersPerHour * cookieStand.AverageCookiesPerSale);
                    cookieStand.HourlySales.Add(new HourlySale { SalePerHour = cookiesSold });
                }

                _context.Cookies.Add(cookieStand);
                await _context.SaveChangesAsync();

                return (CookieStandGetDTO)cookieStand;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<CookieStandGetDTO>> GetCookies()
        {
            try
            {
                var cookieStands = await _context.Cookies.Include(x => x.HourlySales).ToListAsync();
                return cookieStands.Select(cS => (CookieStandGetDTO)cS);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CookieStandGetDTO> GetCookieStand(int id)
        {
            try
            {
                var cookieStand = await _context.Cookies.Include(c => c.HourlySales)
                    .FirstOrDefaultAsync(c => c.ID == id);

                return (CookieStandGetDTO)cookieStand;
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CookieStandGetDTO> PutCookieStand(CookieStand cookieStand)
        {
            _context.Entry(cookieStand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return (CookieStandGetDTO)cookieStand;
        }

        public async Task DeleteCookieStand(int id)
        {
            try
            {
                var cookieStand = await _context.Cookies.FindAsync(id);
                _context.Cookies.Remove(cookieStand);
                await _context.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using Salmon_Cookie_Application_API.Models.DTOs;

namespace Salmon_Cookie_Application_API.Models.Services
{
    public interface ICookieStandService
    {
        Task DeleteCookieStand(int id);
        Task<IEnumerable<CookieStandGetDTO>> GetCookies();
        Task<CookieStandGetDTO> GetCookieStand(int id);
        Task<CookieStandGetDTO> PostCookieStand(CookieStand cookieStand);
        Task<CookieStandGetDTO> PutCookieStand(CookieStand cookieStand);
    }
}
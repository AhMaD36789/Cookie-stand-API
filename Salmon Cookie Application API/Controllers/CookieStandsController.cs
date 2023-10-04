using Microsoft.AspNetCore.Mvc;
using Salmon_Cookie_Application_API.Models;
using Salmon_Cookie_Application_API.Models.DTOs;
using Salmon_Cookie_Application_API.Models.Services;

namespace Salmon_Cookie_Application_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookieStandsController : ControllerBase
    {
        private readonly ICookieStandService _CookieStand;

        public CookieStandsController(ICookieStandService cookieStandService)
        {
            _CookieStand = cookieStandService;
        }

        // GET: api/CookieStands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CookieStandGetDTO>>> GetCookies()
        {
            return Ok(await _CookieStand.GetCookies());
        }

        // GET: api/CookieStands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CookieStandGetDTO>> GetCookieStand(int id)
        {
            var cookieStand = await _CookieStand.GetCookieStand(id);

            return cookieStand;
        }

        // PUT: api/CookieStands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCookieStand(int id, CookieStand cookieStand)
        {
            if (id != cookieStand.ID)
            {
                return BadRequest();
            }

            return Ok(await _CookieStand.PutCookieStand(cookieStand));

        }

        // POST: api/CookieStands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CookieStandGetDTO>> PostCookieStand(CookieStandDTO cookieStandDTO)
        {
            var cookieStand = (CookieStand)cookieStandDTO;
            await _CookieStand.PostCookieStand(cookieStand);

            return CreatedAtAction("GetCookieStand", new { id = cookieStand.ID }, (CookieStandGetDTO)cookieStand);
        }

        // DELETE: api/CookieStands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCookieStand(int id)
        {
            await _CookieStand.DeleteCookieStand(id);

            return NoContent();
        }
    }
}

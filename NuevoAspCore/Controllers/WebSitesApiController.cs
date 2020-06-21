using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Models;
using NuevoAspCore.Models.DbModels;
using NuevoAspCore.Models.Dtos;

namespace NuevoAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebSitesApiController : ControllerBase
    {
        private readonly NuevoContext _context;

        public WebSitesApiController(NuevoContext context)
        {
            _context = context;
        }

        // GET: api/WebSitesApi
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebSitesDto>>> GetWebSites()
        {
            var name = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value)
                .SingleOrDefault());

            var webSitesList = await _context.WebSites.Where(w => w.UserId == name).ToListAsync();


            var webSitesDto = new List<WebSitesDto>();

            foreach (var item in webSitesList)
            {
                webSitesDto.Add(
                    new WebSitesDto
                    {
                        WebSitesId = item.WebSitesId,
                        SiteName = item.SiteName,
                        SiteUrl = item.SiteUrl,
                        LastSuccessCheck = item.LastSuccessCheckDate?.ToString("dd.MM.yyyy H:mm:ss"),
                        ErrorStatus = item.ErrorStatus
                    });
            }



            return webSitesDto;
        }

        // GET: api/WebSitesApi/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<WebSites>> GetWebSites(int id)
        {
            var name = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value)
                .SingleOrDefault());

            var webSites = await _context.WebSites.Include(sites => sites.WebSiteError).Where(sites => sites.UserId == name && sites.WebSitesId == id).FirstOrDefaultAsync();

            if (webSites == null)
            {
                return NotFound();
            }

            return webSites;
        }


        // PUT: api/WebSites1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebSites(int id, WebSites webSites)
        {
            if (id != webSites.WebSitesId)
            {
                return BadRequest();
            }

            _context.Entry(webSites).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebSitesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WebSites1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<WebSites>> PostWebSites(WebSites webSites)
        {
            var name = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value)
                .SingleOrDefault());
            webSites.UserId = name;
            _context.WebSites.Add(webSites);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWebSites", new { id = webSites.WebSitesId }, webSites);
        }

        // DELETE: api/WebSitesApi/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<WebSites>> DeleteWebSites(int id)
        {
            var webSites = await _context.WebSites.FindAsync(id);
            if (webSites == null)
            {
                return NotFound();
            }

            _context.WebSites.Remove(webSites);
            await _context.SaveChangesAsync();

            return webSites;
        }

        private bool WebSitesExists(int id)
        {
            return _context.WebSites.Any(e => e.WebSitesId == id);
        }
    }
}

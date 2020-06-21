using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Models;

namespace NuevoAspCore.Controllers
{
    public class WebSitesController : Controller
    {
        private readonly NuevoContext _context;

        public WebSitesController(NuevoContext context)
        {
            _context = context;
        }

        // GET: WebSites
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        // GET: WebSites/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSites = await _context.WebSites
                .FirstOrDefaultAsync(m => m.WebSitesId == id);
            if (webSites == null)
            {
                return NotFound();
            }

            return View(webSites);
        }
    }
}

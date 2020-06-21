using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Models;
using NuevoAspCore.Models.DbModels;

namespace NuevoAspCore.Helpers.Concrete
{
    public class WesSitesStatus
    {
        private readonly NuevoContext _context;
        public WesSitesStatus(NuevoContext context)
        {
            _context = context;
        }

        public bool StatusCheckAsync(int userid)
        {
            HttpClient client = new HttpClient();

            var webSites = _context.WebSites.Where(u => u.UserId == userid).ToList();

            foreach (var webSite in webSites)
            {
                var checkingResponse = client.GetAsync(webSite.SiteUrl);

                if (checkingResponse.Status != (TaskStatus) 200)
                {

                }
                else
                {
                    SuccessTask(webSite);
                }
            }

            return true;
        }

        public bool SuccessTask(WebSites webSites)
        {
            try
            {
                webSites.LastSuccessCheckDate = DateTime.Now;
                _context.Update(webSites);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebSitesExists(webSites.WebSitesId))
                {
                }
                else
                {
                }
            }

            return true;
        }

        private bool WebSitesExists(int id)
        {
            return _context.WebSites.Any(e => e.WebSitesId == id);
        }
    }
}

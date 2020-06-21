using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NuevoAspCore.Models.DbModels
{
    public sealed class WebSites
    {
        public WebSites()
        {
            WebSiteError = new HashSet<WebSiteError>();
        }


        [Key]
        public int WebSitesId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string SiteName { get; set; }
        [Required]
        public string SiteUrl { get; set; }
       
        public int SitesCheckDelay { get; set; }

        public DateTime? LastSuccessCheckDate { get; set; }
        public int? ErrorStatus { get; set; }


        public Users UsersNavigation { get; set; }
        public ICollection<WebSiteError> WebSiteError { get; set; }
    }
}

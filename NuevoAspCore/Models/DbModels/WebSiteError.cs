using System;
using System.ComponentModel.DataAnnotations;

namespace NuevoAspCore.Models.DbModels
{
    public class WebSiteError
    {
        [Key]
        public int ErrorId { get; set; }
        [Required]
        public int WebSitesId { get; set; }
        [Required]
        public int ErrorStatus { get; set; }
        [Required]
        public DateTime ErrorTime { get; set; }


        public virtual WebSites WebSitesNavigation { get; set; }
    }
}

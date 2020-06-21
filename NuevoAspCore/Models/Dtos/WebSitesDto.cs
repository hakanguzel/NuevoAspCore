namespace NuevoAspCore.Models.Dtos
{
    public class WebSitesDto
    {
        public int WebSitesId { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public string LastSuccessCheck { get; set; }
        public int? ErrorStatus { get; set; }
    }
}

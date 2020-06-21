using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Models.DbModels;

namespace NuevoAspCore.Models
{
    public class NuevoContext : DbContext
    {
        public NuevoContext(DbContextOptions<NuevoContext> options) : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WebSites> WebSites { get; set; }
        public virtual DbSet<WebSiteError> WebSiteError { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WebSites>(entity =>
            {
                entity.HasKey(e => e.WebSitesId);

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.WebSites)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<WebSiteError>(entity =>
            {
                entity.HasKey(e => e.ErrorId);

                entity.HasOne(d => d.WebSitesNavigation)
                    .WithMany(p => p.WebSiteError)
                    .HasForeignKey(d => d.WebSitesId);
            });


            modelBuilder.Entity<Configuration>().HasData(
                new Configuration
                {
                    Id = 1,
                    ConfigurationName = "Delay",
                    ConfigurationValue = "100000"
                }, 
                new Configuration
                {
                    Id = 2,
                    ConfigurationName = "EMailAdress",
                    ConfigurationValue = "hakan-guzel@outlook.com"
                },
                new Configuration
                {
                    Id = 3,
                    ConfigurationName = "EMailPassword",
                    ConfigurationValue = "1111111111111111"
                },
                new Configuration
                {
                    Id = 4,
                    ConfigurationName = "EMailSmtp",
                    ConfigurationValue = "smtp.office365.com"
                },
                new Configuration
                {
                    Id = 5,
                    ConfigurationName = "SendEmailPermission",
                    ConfigurationValue = "0"
                });

            modelBuilder.Entity<Users>().HasData(new Users
            {
                UserId = 1,
                Username = "1",
                Password = "1",
                Email = "hakan-guzel@outlook.com"
            });

            modelBuilder.Entity<WebSites>().HasData(
                new WebSites
            {
                WebSitesId = 1,
                UserId = 1,
                SiteName = "İnstagram",
                SiteUrl = "https://www.instagram.com/",
                SitesCheckDelay = 100000
                }, 
                new WebSites
            {
                WebSitesId = 2,
                UserId = 1,
                SiteName = "GitHub",
                SiteUrl = "https://github.com/",
                SitesCheckDelay = 200000
                }, 
                new WebSites
            {
                WebSitesId = 3,
                UserId = 1,
                SiteName = "Google Play",
                SiteUrl = "https://play.google.com/store",
                SitesCheckDelay = 300000
                });




        }
    }
}

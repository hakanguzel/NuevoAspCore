using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NuevoAspCore.Models.DbModels
{
    public sealed class Users
    {
        public Users()
        {
            WebSites = new HashSet<WebSites>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }


        public ICollection<WebSites> WebSites { get; set; }
    }
}

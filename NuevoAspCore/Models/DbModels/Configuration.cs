using System.ComponentModel.DataAnnotations;

namespace NuevoAspCore.Models.DbModels
{
    public class Configuration
    {
        [Key]
        public int Id { get; set; }

        public string ConfigurationName { get; set; }
        public string ConfigurationValue { get; set; }
    }
}

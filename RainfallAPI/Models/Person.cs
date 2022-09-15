using System.ComponentModel.DataAnnotations;

namespace RainfallAPI.Models
{
    public class Person: ModelBase
    {
        [Required]
        public string GivenName { get; set; }

        public string? FamilyName { get; set; }

        public string? AdditionalNames { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
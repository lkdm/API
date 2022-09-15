using System.ComponentModel.DataAnnotations;

namespace RainfallAPI.Models
{
    /// <summary>
    /// Station is the instrument used to collect data for the recording.
    /// Most often, this is a rain gauge.
    /// </summary>
    public class Station: ModelBase
    {
        [MaxLength(255)]
        public string? Description { get; set; }

        [Required]
        public double Lat { get; set; }

        [Required]
        public double Lon { get; set; }
    }
}
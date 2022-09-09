using System.ComponentModel.DataAnnotations;

namespace HabitRaceAPI.Dtos
{
    public class HabitCreateDto
    {
        [MaxLength(1)]
        public string? Icon { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
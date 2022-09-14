using System.ComponentModel.DataAnnotations;

namespace HabitRaceAPI.Models
{
    public class Habit
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(1)]
        public string? Icon { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
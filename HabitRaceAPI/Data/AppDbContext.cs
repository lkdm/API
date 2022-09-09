using HabitRaceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HabitRaceAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Habit> Habits => Set<Habit>();
    }
}

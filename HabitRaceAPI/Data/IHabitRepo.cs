using HabitRaceAPI.Models;

namespace HabitRaceAPI.Data
{
    public interface IHabitRepo
    {
        Task SaveChanges();
        Task<Habit?> GetHabitById(Guid Id);
        Task<IEnumerable<Habit>> GetAllHabits();
        Task CreateHabit(Habit habit);

        void DeleteHabit(Habit habit);

    }
}


using HabitRaceAPI.Models;

namespace HabitRaceAPI.Data;

public class HabitRepo : IHabitRepo
{
    private readonly AppDbContext _context;
    public HabitRepo(AppDbContext context)
    {
        _context = context;
    }
    public Task CreateHabit(Habit habit)
    {
        throw new NotImplementedException();
    }

    public void DeleteHabit(Habit habit)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Habit>> GetAllHabits()
    {
        throw new NotImplementedException();
    }

    public Task<Habit?> GetHabitById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}
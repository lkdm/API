using AutoMapper;
using HabitRaceAPI.Models;
using HabitRaceAPI.Dtos;

namespace HabitRaceAPI.Profiles
{
    public class HabitsProfile : Profile
    {
        public HabitsProfile()
        {
            // Source ->> Target
            CreateMap<Habit, HabitReadDto>();
            CreateMap<HabitCreateDto, Habit>();
            CreateMap<HabitUpdateDto, Habit>();
        }
    }
}
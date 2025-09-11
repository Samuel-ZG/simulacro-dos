using Microsoft.EntityFrameworkCore;
using WellnessHubAPI.Models;

namespace WellnessHubAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Habit> Habits { get; set; }
        public DbSet<MoodEntry> MoodEntries { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Workout> Workouts { get; set; }
    }
}
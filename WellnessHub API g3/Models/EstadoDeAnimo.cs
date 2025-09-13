using System;
using System.ComponentModel.DataAnnotations;

namespace WellnessHubAPI.Models
{
    public class MoodEntry
    {
        public int Id { get; set; }

        [Required]
        public string User { get; set; }

        public DateTime EntryDate { get; set; }

        public int Mood { get; set; } // por ejemplo 1-10

        public int Energy { get; set; } // 1-10

        public double SleepHours { get; set; }

        public int StressLevel { get; set; } // 1-10
    }
}
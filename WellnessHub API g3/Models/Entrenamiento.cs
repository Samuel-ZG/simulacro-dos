using System;
using System.ComponentModel.DataAnnotations;

namespace WellnessHubAPI.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required]
        public string User { get; set; }

        public DateTime SessionDate { get; set; }

        public string Exercise { get; set; }

        public int DurationMinutes { get; set; }

        public string Intensity { get; set; } // Baja/Media/Alta

        public int CaloriesBurned { get; set; }
    }
}
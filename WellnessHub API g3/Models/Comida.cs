using System;
using System.ComponentModel.DataAnnotations;

namespace WellnessHubAPI.Models
{
    public class Meal
    {
        public int Id { get; set; }

        [Required]
        public string User { get; set; }

        public DateTime EntryDate { get; set; }

        public string FoodName { get; set; }

        public int Calories { get; set; }

        public double Protein { get; set; }

        public double Carbs { get; set; }

        public double Fat { get; set; }
    }
}
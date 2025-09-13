using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public class Habit
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Usuario")]
    public string User { get; set; } = null!;

    [Required]
    [MaxLength(200)]
    [Display(Name = "Título")]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    [MaxLength(50)]
    [Display(Name = "Frecuencia")]
    public string? Frequency { get; set; }

    [MaxLength(50)]
    [Display(Name = "Estado")]
    public string? Status { get; set; }
}
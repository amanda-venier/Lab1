using System.ComponentModel.DataAnnotations;

namespace Lab1.Models;

public class Employer
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required]
    [Url]
    public string Website { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Incorporated Date")]
    public DateTime? IncorporatedDate { get; set; }
}

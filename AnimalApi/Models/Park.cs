using System.ComponentModel.DataAnnotations;

namespace AnimalApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    [Range(0, 2, ErrorMessage = "Enter the two letter abbreviation.")]
    public string Name { get; set; }    
  }
}
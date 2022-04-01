using System.ComponentModel.DataAnnotations;

namespace AnimalApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public string Sex { get; set; }
    [Required]
    [Range(0, 25, ErrorMessage = "We only list living animals. None over 25.")]
    public int Age { get; set; }
  }
}
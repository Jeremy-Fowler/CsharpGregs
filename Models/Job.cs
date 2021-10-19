using System.ComponentModel.DataAnnotations;

namespace CsharpGregs.Models
{
  public class Job
  {
    public int Id {get; set;}
    [Required]
    [MinLength(3)]
    public string Company {get; set;}
    [Required]
    [MinLength(3)]
    public string JobTitle {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Hours {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Rate {get; set;}
    [MinLength(3)]
    public string Description {get; set;}
  }
}
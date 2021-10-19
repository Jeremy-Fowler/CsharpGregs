using System.ComponentModel.DataAnnotations;

namespace CsharpGregs.Models
{
  public class House
  {
    public int Id {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Bedrooms {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Bathrooms {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Levels {get; set;}
    [Required]
    [Url]
    public string ImgUrl {get; set;}
    [Required]
    [Range(1800, 2021)]
    public int Year {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Price {get; set;}
    [Required]
    [MinLength(4)]
    public string Description {get; set;}
  }
}
using System.ComponentModel.DataAnnotations;

namespace CsharpGregs.Models 
{
  public class Car
  {
    public int Id {get; set;}

    [Required]
    [MinLength(3)]
    public string Make {get; set;}

    [Required]
    [MinLength(3)]
    public string Model {get; set;}

    [Required]
    [Range(1900, 2022)]
    public int Year {get; set;}

    [Required]
    [Range(1, int.MaxValue)]
    public int Price {get; set;}

    [Url]
    public string ImgUrl {get; set;}
    [MinLength(3)]
    public string Description {get; set;}
  }
}
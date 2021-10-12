using System.ComponentModel.DataAnnotations;

namespace Model {
public class Person {
    
    public int Id { get; set; }
    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }
    [Required]
    [MinLength(2)]
    public string LastName { get; set; }
    [Required]
    [MinLength(4)]
    public string HairColor { get; set; }
    [Required]
    [MinLength(4)]
    public string EyeColor { get; set; }
    [Required]
    [Range(0,200)]
    public int Age { get; set; }
    [Range(0,900)]
    public float Weight { get; set; }
    [Range(30,300)]
    public int Height { get; set; }
    [RegularExpression("F|M|O", ErrorMessage = "Gender must be either 'M', 'F' or 'O'.")]
    public string Sex { get; set; }
}


}
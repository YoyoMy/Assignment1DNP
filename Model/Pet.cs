using System.ComponentModel.DataAnnotations;

namespace Model {
public class Pet {
    public int Id { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [Range(0,200)]
    public int Age { get; set; }
}
}
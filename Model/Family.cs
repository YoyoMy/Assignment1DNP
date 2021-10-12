using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model {
public class Family {
    
    public int Id { get; set; }
    [Required]
    [MinLength(2)]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();     
    }
}


}
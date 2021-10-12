using System.ComponentModel.DataAnnotations;

namespace Model{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Username {get;set;}
        [Required]
        [MinLength(4)]
        public string Password {get;set;}
        [Required]
        [MinLength(2)]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2)]
        public string LastName {get;set;}
        public string Role {get;set;}
    }
}
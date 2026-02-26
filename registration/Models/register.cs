using System.ComponentModel.DataAnnotations;

namespace registration.Models
{
    public class register
    {
        [Required(ErrorMessage ="Name is required")]
       
        [RegularExpression(@"^[A-Za-z]+$",
            ErrorMessage = "Name must contain only alphabets.")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Email is required")]
        
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        
        [RegularExpression(
            @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$",
            ErrorMessage = "Password must contain at least one uppercase,one loweacse,one digit,one number")]
            [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
            public string Password { get; set; }
      
        [Required(ErrorMessage = "Age is required")]
       
        [Range(18,60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
    }
}

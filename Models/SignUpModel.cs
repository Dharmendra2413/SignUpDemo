using SignUpDemo.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpDemo.Models
{
    public class SignUpModel
    {
        //public List<string> CityNames { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare(nameof(Password), ErrorMessage = "Password and confirm password not match")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Contact is required")]
        [RegularExpression(@"^([0-9]{10}$)", ErrorMessage = "Invalid Contact Number")]
        
        public string Contact { get; set; }
        [Required(ErrorMessage = "Country Name is required")]
        public string Country { get; set; }
        
        [Required(ErrorMessage = "City name is required")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        public List<string> CityNames { get; set; }

        [ValidateCheckBox(ErrorMessage = "Terms and Condition is required")]
        public bool Terms { get; set; }
    }
}

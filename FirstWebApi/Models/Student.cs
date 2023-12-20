using FirstWebApi.Validator;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApi.Models
{
    public class Student
    {

      //  [ValidateNever] 
        public int studentId { get; set; }

       // [Required(ErrorMessage = "Please enter name")]
       // [StringLength(100, MinimumLength = 2)]

        public string studentName { get; set;}
       // [AgeValidator(ErrorMessage="Age is not valid")]
        public int studentAge { get; set;}

        [Required]
        public string password {  get; set; }

        [Compare(nameof(password))]
        public string? confirmPassword {  get; set; }

      
    }
}

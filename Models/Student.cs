using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Student")]
    public class Student : Person
    {
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Universisty { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Address { get; set; }
     
        public string PhoneNumber { get; set; }
        
        public string Age { get; set; }




    }
}
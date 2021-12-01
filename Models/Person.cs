using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
    
        public string PersonCode { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string FullName { get; set; }

        public ICollection<HoaDon> hoadons { get; set; }

    }
}
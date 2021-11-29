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
        public string FullName { get; set; }

        public ICollection<HoaDon> hoadons { get; set; }

    }
}
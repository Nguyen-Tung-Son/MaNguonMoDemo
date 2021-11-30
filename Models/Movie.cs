using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// doi ten namespace
namespace DemoMVC.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required (ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
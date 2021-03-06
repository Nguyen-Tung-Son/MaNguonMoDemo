using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Display(Name = "ID sản phẩm")]
        public string ProductId { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }
        private double _Price;
        [DataType(DataType.Currency), Display(Name = "Giá")]
        public double Price
        {
            get { return _Price; }
            set { if (value > 0) _Price = value; }
        }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("SinhViens")]
    public class SinhVien
    {
        [Key]
        public String SinhVienID {get;set;}
        public String HoTen {get;set;}
    }
}

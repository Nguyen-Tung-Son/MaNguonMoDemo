using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Movie> Movie { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        
       
    }
}
using BurcunurKurt.WebApiDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurcunurKurt.WebApiDemo.DataAccess
{
    public class NorthwindContext:DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AQEEA24\MSSQLSERVER03; Database=Northwind; Trusted_Connection=true");
        }
        public DbSet <Product> Products { get; set; }
    }
}

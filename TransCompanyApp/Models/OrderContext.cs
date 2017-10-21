using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransCompanyApp.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseMySQL("Server=10.10.0.103;userid=dev;password=dev;port=3306;database=devbase;charset=UTF-8;");
        //}

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
    }
}

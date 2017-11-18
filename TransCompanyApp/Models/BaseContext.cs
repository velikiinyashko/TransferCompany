using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransCompanyApp.Models
{
    public class BaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<CarManufacture> CarManufactures { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<billing.Client> Clients { get; set; }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
    }
}

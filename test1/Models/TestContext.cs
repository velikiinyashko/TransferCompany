using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test1.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> option) : base(option)
        {

        }

        public DbSet<TestModel> Tests { get; set; }
    }
}

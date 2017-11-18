using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Comment { get; set; }

        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}

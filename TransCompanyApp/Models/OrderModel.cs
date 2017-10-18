using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
    }
}

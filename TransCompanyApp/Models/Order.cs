using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TransCompanyApp.Models
{
    public partial class Order
    {

        public int Id { get; set; }

        public DateTime TimeCreate { get; set; }

        public List<Address> Address { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int? StatisId { get; set; } 
        public Status Status { get; set; }

        public int? TariffId { get; set; }
        public Tariff Tariff { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public Order()
        {
            Address = new List<Models.Address>();
        }
    }
}

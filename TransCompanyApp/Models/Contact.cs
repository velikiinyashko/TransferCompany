using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}

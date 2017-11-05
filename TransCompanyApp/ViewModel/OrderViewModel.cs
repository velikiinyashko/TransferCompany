using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransCompanyApp.Models;

namespace TransCompanyApp.ViewModel
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<TariffModel> Tariffs { get; set; }
    }
}

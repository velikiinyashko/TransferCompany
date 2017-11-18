using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CarManufactureId { get; set; }
        public CarManufacture Manufacture { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public class CarManufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> Models { get; set; }

        public CarManufacture()
        {
            Models = new List<CarModel>();
        }

    }
}

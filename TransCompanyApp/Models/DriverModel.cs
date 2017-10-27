using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransCompanyApp.Models
{
    public enum CarCompany
    {

    }

    public enum CarModel
    {

    }

    public partial class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }

    }
}

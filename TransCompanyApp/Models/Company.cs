using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TransCompanyApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано название компании")]
        public string Name { get; set; }
        public string Country { get; set; }
        [Required]
        public string Sity { get; set; }
        public string PostIndex { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Введине ИНН")]
        public int INN { get; set; }
        public int OGRN { get; set; }
        public int KPP { get; set; }
        public int BIK { get; set; }
    }
}

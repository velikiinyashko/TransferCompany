using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TransCompanyApp.Models
{
    public enum Status
    {
        Pending, //ожидание
        Confirmed, //подтвержден
        Cancelled, //отменен
        Paid, //оплачен
        Complete //завершен
    }

    public partial class Order
    {

        public int Id { get; set; }

        public DateTime TimeCreate { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        //[RegularExpression(@"[0-9+]{7,12}", ErrorMessage = "Некорректный номер")]
        [Phone (ErrorMessage = "Некорректный номер")]
        public string Phone { get; set; }
        [EmailAddress (ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        public Status Status { get; set; }

        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Status Status { get; set; }

        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
    }
}

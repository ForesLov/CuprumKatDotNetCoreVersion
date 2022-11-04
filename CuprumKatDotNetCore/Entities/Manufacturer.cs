using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            EDeliveries = new HashSet<EDelivery>();
            Products = new HashSet<Product>();
        }

        public int ManufId { get; set; }
        public string? CompanyName { get; set; }
        public string? UrAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Ogrn { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? Okpo { get; set; }
        public string? Okved { get; set; }
        public string? CeoLname { get; set; }
        public string? CeoName { get; set; }
        public string? CeoSname { get; set; }
        public string? RepresLname { get; set; }
        public string? RespersName { get; set; }
        public string? RespersSname { get; set; }
        public string? RespersPhone { get; set; }
        public string? RespersPose { get; set; }

        public virtual ICollection<EDelivery> EDeliveries { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

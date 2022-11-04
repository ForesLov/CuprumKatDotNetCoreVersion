using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class EDelivery
    {
        public int IdDeliv { get; set; }
        public DateTime? DelivDate { get; set; }
        public int? IdProduct { get; set; }
        public int? DelivAmount { get; set; }
        public decimal? DelivCost { get; set; }
        public int? ManufId { get; set; }
        public int? UId { get; set; }

        public virtual Product? IdProductNavigation { get; set; }
        public virtual Manufacturer? Manuf { get; set; }
        public virtual IsUser? UIdNavigation { get; set; }
    }
}

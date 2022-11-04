using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class ProductWriteOff
    {
        public int IdOff { get; set; }
        public int? ProductId { get; set; }
        public int? AmountOff { get; set; }
        public decimal? CostOff { get; set; }
        public int? UId { get; set; }
        public DateTime? DateOff { get; set; }

        public virtual Product? Product { get; set; }
        public virtual IsUser? UIdNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class DeliveryView
    {
        public int IdDeliv { get; set; }
        public DateTime? DelivDate { get; set; }
        public string? ProductName { get; set; }
        public int? DelivAmount { get; set; }
        public decimal? DelivCost { get; set; }
        public string? ULname { get; set; }
        public string? UName { get; set; }
        public string? USname { get; set; }
    }
}

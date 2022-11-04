using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class WriteOff
    {
        public int IdOff { get; set; }
        public string? ProductName { get; set; }
        public int? AmountOff { get; set; }
        public decimal? CostOff { get; set; }
        public string? ULname { get; set; }
        public string? UName { get; set; }
        public string? USname { get; set; }
        public DateTime? DateOff { get; set; }
    }
}

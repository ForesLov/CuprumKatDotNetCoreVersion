using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class ProductView
    {
        public int IdProduct { get; set; }
        public string? ProductName { get; set; }
        public string? ProductMeasure { get; set; }
        public int? ProductAmount { get; set; }
        public string? CompanyName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string? StorePurpose { get; set; }
    }
}

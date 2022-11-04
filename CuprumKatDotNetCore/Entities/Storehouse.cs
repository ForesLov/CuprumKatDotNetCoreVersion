using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class Storehouse
    {
        public Storehouse()
        {
            Products = new HashSet<Product>();
        }

        public int IdStore { get; set; }
        public string? StorePurpose { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

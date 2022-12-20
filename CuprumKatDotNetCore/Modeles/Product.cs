using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class Product : DbEntity
{
    public Product()
    {
        EDeliveries = new HashSet<EDelivery>();
        ProductWriteOffs = new HashSet<ProductWriteOff>();
    }
    public string? ProductName { get; set; }
    public string? ProductMeasure { get; set; }
    public int? ProductAmount { get; set; }
    public int? IdManfc { get; set; }
    public decimal? ProductPrice { get; set; }
    public int? IdStore { get; set; }

    public virtual Manufacturer? IdManfcNavigation { get; set; }
    public virtual Storehouse? IdStoreNavigation { get; set; }
    public virtual ICollection<EDelivery> EDeliveries { get; set; }
    public virtual ICollection<ProductWriteOff> ProductWriteOffs { get; set; }
}

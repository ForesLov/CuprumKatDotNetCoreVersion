using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class EDelivery : DbEntity
{

    public DateTime? DelivDate { get; set; }
    public int? DelivAmount { get; set; }
    public decimal? DelivCost { get; set; }
    public virtual Product? IdProductNavigation { get; set; }
    public virtual Manufacturer? Manuf { get; set; }
    public virtual User? UIdNavigation { get; set; }
}

using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class EDelivery : DbEntity
{

    public DateTime? DelivDate { get; set; }
    public int? IdProduct { get; set; }
    public int? DelivAmount { get; set; }
    public decimal? DelivCost { get; set; }
    public int? ManufId { get; set; }
    public int? UId { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
    public virtual Manufacturer? Manuf { get; set; }
    public virtual User? UIdNavigation { get; set; }
}

using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class ProductWriteOff : DbEntity
{
    public int? ProductId { get; set; }
    public int? AmountOff { get; set; }
    public decimal? CostOff { get; set; }
    public int? UId { get; set; }
    public DateTime? DateOff { get; set; }

    public virtual Product? Product { get; set; }
    public virtual User? UIdNavigation { get; set; }
}

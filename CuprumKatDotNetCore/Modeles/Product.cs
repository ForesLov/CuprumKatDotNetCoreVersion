using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class Product : DbEntity
{

    public string? ProductName { get; set; }
    public string? ProductMeasure { get; set; }
    public int? ProductAmount { get; set; }
    public decimal? ProductPrice { get; set; }
    public virtual Manufacturer? Manufacturers { get; set; }
    public virtual Storehouse? Storehouses { get; set; }

}

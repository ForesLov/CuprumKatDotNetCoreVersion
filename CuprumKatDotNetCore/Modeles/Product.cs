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
    public  Manufacturer? Manufacturers { get; set; }
    public  Storehouse? Storehouses { get; set; }
    public override string ToString()
    {
        return $"{ProductName}";
    }

}

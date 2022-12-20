using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class ProductView : DbEntity
{
    public string? ProductName { get; set; }
    public string? ProductMeasure { get; set; }
    public int? ProductAmount { get; set; }
    public string? CompanyName { get; set; }
    public decimal? ProductPrice { get; set; }
    public string? StorePurpose { get; set; }
}

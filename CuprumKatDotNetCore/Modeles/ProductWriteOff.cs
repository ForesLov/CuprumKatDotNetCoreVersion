using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class ProductWriteOff : DbEntity
{
    public int? AmountOff { get; set; }
    public decimal? CostOff { get; set; }
    public DateTime? DateOff { get; set; }
    public User? Users { get; set; }
    public Product? product { get; set; }
}

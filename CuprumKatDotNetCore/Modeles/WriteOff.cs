using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class WriteOff : DbEntity
{
    public string? ProductName { get; set; }
    public int? AmountOff { get; set; }
    public decimal? CostOff { get; set; }
    
    public DateTime? DateOff { get; set; }
}
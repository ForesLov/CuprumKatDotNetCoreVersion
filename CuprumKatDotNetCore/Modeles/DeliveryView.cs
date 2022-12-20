using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class DeliveryView : DbEntity
{

    public DateTime? DelivDate { get; set; }
    public string? ProductName { get; set; }
    public int? DelivAmount { get; set; }
    public decimal? DelivCost { get; set; }
    public string? ULname { get; set; }
    public string? UName { get; set; }
    public string? USname { get; set; }
}

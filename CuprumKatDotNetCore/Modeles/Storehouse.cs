using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class Storehouse : DbEntity
{
    public Storehouse()
    {
        Products = new HashSet<Product>();
    }


    public string? StorePurpose { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

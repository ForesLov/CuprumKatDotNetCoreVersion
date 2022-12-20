using CuprumKatDotNetCore.Modeles;
using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Modeles;

public class CompanyPose : DbEntity
{
    public CompanyPose()
    {
    }
    public override string ToString()
    {
        return $"{PoseName}";
    }
    public string? PoseName { get; set; }
}

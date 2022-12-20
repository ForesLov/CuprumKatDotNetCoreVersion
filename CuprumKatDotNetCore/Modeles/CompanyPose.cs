using CuprumKatDotNetCore.Modeles;
using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Modeles;

public class CompanyPose : DbEntity
{
    public CompanyPose()
    {
        IsUsers = new HashSet<IsUser>();
    }

    public int IdPose { get; set; }
    public string? PoseName { get; set; }
    public virtual ICollection<IsUser> IsUsers { get; set; }
}

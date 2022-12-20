using CuprumKatDotNetCore.Modeles;
using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Modeles;

public class CompanyPose : DbEntity
{
    public CompanyPose()
    {
        IsUsers = new HashSet<User>();
    }

    public int IdPose { get; set; }
    public string? PoseName { get; set; }
    public virtual ICollection<User> IsUsers { get; set; }
}

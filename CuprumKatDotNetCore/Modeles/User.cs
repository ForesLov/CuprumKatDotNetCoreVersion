using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class User : DbEntity
{
    public string? ULname { get; set; }
    public string? UName { get; set; }
    public string? USname { get; set; }
    public string? UAddress { get; set; }
    public string? UphoneNumber { get; set; }
    public string? UEmail { get; set; }
    public string? ULog { get; set; }
    public string? UPass { get; set; }
    public virtual CompanyPose? Pose { get; set; }
}

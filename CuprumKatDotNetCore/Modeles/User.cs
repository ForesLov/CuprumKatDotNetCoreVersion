using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class User : DbEntity
{
    public User()
    {
        EDeliveries = new HashSet<EDelivery>();
        ProductWriteOffs = new HashSet<ProductWriteOff>();
    }
    public string? ULname { get; set; }
    public string? UName { get; set; }
    public string? USname { get; set; }
    public string? UAddress { get; set; }
    public string? UphoneNumber { get; set; }
    public string? UEmail { get; set; }
    public string? ULog { get; set; }
    public string? UPass { get; set; }
    public virtual CompanyPose? Pose { get; set; }

    public virtual ICollection<EDelivery>? EDeliveries { get; set; }
    public virtual ICollection<ProductWriteOff>? ProductWriteOffs { get; set; }
}

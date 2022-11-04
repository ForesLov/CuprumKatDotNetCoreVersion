using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class IsUser
    {
        public IsUser()
        {
            EDeliveries = new HashSet<EDelivery>();
            ProductWriteOffs = new HashSet<ProductWriteOff>();
        }

        public int IdUser { get; set; }
        public string? ULname { get; set; }
        public string? UName { get; set; }
        public string? USname { get; set; }
        public string? UAddress { get; set; }
        public string? UphoneNumber { get; set; }
        public string? UEmail { get; set; }
        public int? IdPose { get; set; }
        public int? IdUAccount { get; set; }

        public virtual CompanyPose? IdPoseNavigation { get; set; }
        public virtual Account? IdUAccountNavigation { get; set; }
        public virtual ICollection<EDelivery> EDeliveries { get; set; }
        public virtual ICollection<ProductWriteOff> ProductWriteOffs { get; set; }
    }
}

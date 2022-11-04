using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class CompanyPose
    {
        public CompanyPose()
        {
            IsUsers = new HashSet<IsUser>();
        }

        public int IdPose { get; set; }
        public string? PoseName { get; set; }

        public virtual ICollection<IsUser> IsUsers { get; set; }
    }
}

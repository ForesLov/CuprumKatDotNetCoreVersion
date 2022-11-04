using System;
using System.Collections.Generic;

namespace CuprumKatDotNetCore.Entities
{
    public partial class Account
    {
        public Account()
        {
            IsUsers = new HashSet<IsUser>();
        }

        public int IdAccount { get; set; }
        public string? ULog { get; set; }
        public string? UPass { get; set; }

        public virtual ICollection<IsUser> IsUsers { get; set; }
    }
}

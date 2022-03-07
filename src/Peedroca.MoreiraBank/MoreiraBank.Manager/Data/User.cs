using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class User
    {
        public User()
        {
            Profiles = new HashSet<Profile>();
        }

        public int Iduser { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}

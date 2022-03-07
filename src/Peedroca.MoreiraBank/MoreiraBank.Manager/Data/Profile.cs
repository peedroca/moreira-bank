using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class Profile
    {
        public int Idprofile { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}

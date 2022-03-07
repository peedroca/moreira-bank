using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class Profile
    {
        public Profile()
        {
            Earnings = new HashSet<Earning>();
            EstimatedInvestments = new HashSet<EstimatedInvestment>();
            Investiments = new HashSet<Investiment>();
            Spendings = new HashSet<Spending>();
        }

        public int Idprofile { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Earning> Earnings { get; set; }
        public virtual ICollection<EstimatedInvestment> EstimatedInvestments { get; set; }
        public virtual ICollection<Investiment> Investiments { get; set; }
        public virtual ICollection<Spending> Spendings { get; set; }
    }
}

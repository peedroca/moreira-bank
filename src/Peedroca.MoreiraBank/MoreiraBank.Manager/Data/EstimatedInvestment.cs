using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class EstimatedInvestment
    {
        public int IdestimatedInvestment { get; set; }
        public decimal Amount { get; set; }
        public int ProfileId { get; set; }
        public int? CalendarId { get; set; }

        public virtual Calendar? Calendar { get; set; }
        public virtual Profile Profile { get; set; } = null!;
    }
}

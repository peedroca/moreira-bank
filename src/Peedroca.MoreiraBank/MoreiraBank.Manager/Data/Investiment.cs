using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class Investiment
    {
        public int Idinvestiment { get; set; }
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Amount { get; set; }
        public decimal EstimatedProfit { get; set; }
        public int? ProfileId { get; set; }

        public virtual Profile? Profile { get; set; }
    }
}

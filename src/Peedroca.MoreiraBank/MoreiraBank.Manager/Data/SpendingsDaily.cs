using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class SpendingsDaily
    {
        public int IdspendingDaily { get; set; }
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public int SpendingCategoryId { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; } = null!;
        public virtual SpendingCategory SpendingCategory { get; set; } = null!;
    }
}

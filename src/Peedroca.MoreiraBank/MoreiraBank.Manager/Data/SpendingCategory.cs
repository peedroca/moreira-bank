using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class SpendingCategory
    {
        public SpendingCategory()
        {
            SpendingsDailies = new HashSet<SpendingsDaily>();
        }

        public int IdspendingCategory { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<SpendingsDaily> SpendingsDailies { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Data
{
    public partial class Calendar
    {
        public Calendar()
        {
            EstimatedInvestments = new HashSet<EstimatedInvestment>();
        }

        public int Idcalendar { get; set; }
        public string CalendarDate { get; set; } = null!;
        public string CalendarYear { get; set; } = null!;
        public string CalendarMonth { get; set; } = null!;

        public virtual ICollection<EstimatedInvestment> EstimatedInvestments { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Data.Repositories
{
    internal class SpendingRepository : Repository<Spending>
    {
        public IEnumerable<Spending> GetAll(long profileId)
        {
            return context.Spendings
                .AsNoTracking()
                .Where(w => w.ProfileId == profileId);
        }
    }
}

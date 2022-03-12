using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Data.Repositories
{
    internal class EarningRepository : Repository<Earning>
    {
        public IEnumerable<Earning> GetAll(long profileId)
        {
            return context.Earnings
                .AsNoTracking()
                .Where(w => w.ProfileId == profileId);
        }
    }
}

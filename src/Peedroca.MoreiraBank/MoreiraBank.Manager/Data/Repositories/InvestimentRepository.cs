using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Data.Repositories
{
    internal class InvestimentRepository : Repository<Investiment>
    {
        public IEnumerable<Investiment> GetAll(long profileId)
        {
            return context.Investiments
                .AsNoTracking()
                .Where(w => w.ProfileId == profileId);
        }
    }
}

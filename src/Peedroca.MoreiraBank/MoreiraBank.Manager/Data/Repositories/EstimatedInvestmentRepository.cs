using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Data.Repositories
{
    internal class EstimatedInvestmentRepository : Repository<EstimatedInvestment>
    {
        public IEnumerable<EstimatedInvestment> GetAll(long profileId)
        {
            return context.EstimatedInvestments
                .AsNoTracking()
                .Include(i => i.Calendar)
                .Where(w => w.ProfileId == profileId);
        }
    }
}

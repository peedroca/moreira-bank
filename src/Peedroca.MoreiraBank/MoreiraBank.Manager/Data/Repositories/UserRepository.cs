using Microsoft.EntityFrameworkCore;

namespace MoreiraBank.Manager.Data.Repositories
{
    internal class UserRepository : Repository<User>
    {
        public override IEnumerable<User> GetAll()
        {
            return context
                .Users
                .Include(u => u.Profiles);
        }
    }
}

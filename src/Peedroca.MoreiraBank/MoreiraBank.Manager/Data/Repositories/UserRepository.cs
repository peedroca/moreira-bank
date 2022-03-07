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

        public User? Login(string username, string password)
        {
            return context.Users
                .AsNoTracking()
                .Where(w => w.Name == username && w.Password == password)
                .SingleOrDefault();
        }
    }
}

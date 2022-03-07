using MoreiraBank.Manager.Data.Repositories;

namespace MoreiraBank.Manager.Business
{
    internal class UserBusiness
    {
        private readonly UserRepository repository;

        public UserBusiness()
        {
            repository = new UserRepository();
        }

        public void Create()
    }
}

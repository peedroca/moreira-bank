using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class UserBusiness
    {
        private readonly UserRepository userRepository;
        private readonly ProfileRepository profileRepository;

        public UserBusiness()
        {
            userRepository = new UserRepository();
            profileRepository = new ProfileRepository();
        }

        public UserModel Create(UserModel model)
        {
            User user = model;
            
            userRepository.Create(user);
            profileRepository.Create(model.Profiles.Single());

            userRepository.SaveChanges();

            return user;
        }
    }
}

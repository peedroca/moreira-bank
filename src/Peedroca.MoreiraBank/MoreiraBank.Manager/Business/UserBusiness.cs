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

        public Response<UserModel> Create(UserModel model)
        {
            if (!model.IsValid)
                return new Response<UserModel>(model.Notifications);

            User user = model;
            
            userRepository.Create(user);
            profileRepository.Create(model.Profiles.Single());

            userRepository.SaveChanges();

            return new Response<UserModel>(user);
        }

        public List<UserModel> GetUsers()
        {
            var users = userRepository.GetAll();
            return users.Select(user => (UserModel)user).ToList();
        }
    }
}

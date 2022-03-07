using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.ValueObjects;

namespace MoreiraBank.Manager.Models
{
    internal class UserModel : ModelBase
    {
        private readonly List<ProfileModel> _profiles;

        public UserModel(int idUser, Credential credential)
        {
            IdUser = idUser;
            Credential = credential;

            _profiles = new List<ProfileModel>();

            AddNotifications(credential);
        }

        public int IdUser { get; private set; }
        public Credential? Credential { get; private set; }

        public IReadOnlyCollection<ProfileModel> Profiles { get { return _profiles.ToArray(); } }

        public void AddProfile(params ProfileModel[] profile)
        {
            AddNotifications(profile);
            _profiles.AddRange(profile);
        }

        public static implicit operator User(UserModel model)
        {
            return new User()
            {
                Iduser = model.IdUser,
                Name = model.Credential?.Username ?? string.Empty,
                Password = model.Credential?.HashPassword ?? string.Empty,
                Profiles = model.Profiles.Select(p => (Profile)p).ToList()
            };
        }

        public static implicit operator UserModel(User user)
        {
            var model = new UserModel(user.Iduser, new Credential(user.Name));
            model.AddProfile(user.Profiles.Select(p => (ProfileModel)p).ToArray());

            return model;
        }
    }
}

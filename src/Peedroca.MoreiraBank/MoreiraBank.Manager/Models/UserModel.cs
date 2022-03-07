using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class UserModel
    {
        private List<ProfileModel> _profiles;

        public UserModel()
        {
            IdUser = 0;
            Name = string.Empty;
            Password = string.Empty;

            _profiles =  new List<ProfileModel>();
        }

        public UserModel(int idUser, string name, string password)
        {
            IdUser = idUser;
            Name = name;
            Password = password;

            _profiles = new List<ProfileModel>();
        }

        public int IdUser { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }

        public IReadOnlyCollection<ProfileModel> Profiles { get { return _profiles.ToArray(); } }

        public void AddProfile(params ProfileModel[] profile) => _profiles.AddRange(profile);

        public static implicit operator User(UserModel model)
        {
            return new User()
            {
                Iduser = model.IdUser,
                Name = model.Name,
                Password = model.Password,
                Profiles = model.Profiles.Select(p => (Profile)p).ToList()
            };
        }

        public static implicit operator UserModel(User user)
        {
            var model = new UserModel()
            {
                IdUser = user.Iduser,
                Name = user.Name,
                Password = user.Password
            };

            model.AddProfile(user.Profiles.Select(p => (ProfileModel)p).ToArray());

            return model;
        }

        public static UserModel New(string name, string password)
        {
            return new UserModel(0, name, GetPasswordEncrypted(password));
        }

        public static string GetPasswordEncrypted(string password) => string.Empty;
    }
}

using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.ValueObjects;

namespace MoreiraBank.Manager.Models
{
    internal class ProfileModel : ModelBase
    {
        public ProfileModel(int idProfile, Name name, Email email)
        {
            IdProfile = idProfile;
            Name = name;
            Email = email;

            AddNotifications(name, email);
        }

        public int IdProfile { get; private set; }
        public Name? Name { get; private set; }
        public Email? Email { get; private set; }

        public static implicit operator Profile(ProfileModel model)
        {
            return new Profile()
            {
                Idprofile = model.IdProfile,
                FirstName = model.Name?.FirstName,
                LastName = model.Name?.LastName,
                Email = model.Email?.Content,
            };
        }

        public static implicit operator ProfileModel(Profile profile)
        {
            return new ProfileModel(profile.Idprofile
                , new Name(profile.FirstName ?? string.Empty, profile.LastName ?? string.Empty)
                , new Email(profile.Email)
            );
        }
    }
}

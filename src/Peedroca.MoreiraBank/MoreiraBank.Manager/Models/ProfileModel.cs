using Flunt.Notifications;
using Flunt.Validations;
using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class ProfileModel : Model
    {
        public ProfileModel()
        {
            IdProfile = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        public ProfileModel(int idProfile, string firstName, string lastName, string email)
        {
            IdProfile = idProfile;
            FirstName = firstName;
            LastName = lastName;
            Email = email;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotEmpty(FirstName, "Profile.FirstName")
                .IsNotEmpty(LastName, "Profile.LastName")
                .IsNotEmpty(Email, "Profile.Email")
            );
        }

        public int IdProfile { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public static implicit operator Profile(ProfileModel model)
        {
            return new Profile()
            { 
                Idprofile = model.IdProfile,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
            };
        }

        public static implicit operator ProfileModel(Profile profile)
        {
            return new ProfileModel()
            {
                IdProfile = profile.Idprofile,
                FirstName = profile.FirstName ?? string.Empty,
                LastName = profile.LastName ?? string.Empty,
                Email = profile.Email ?? string.Empty,
            };
        }

        public static ProfileModel New(string firstName, string lastName, string email)
        {
            return new ProfileModel(0, firstName, lastName, email);
        }
    }
}

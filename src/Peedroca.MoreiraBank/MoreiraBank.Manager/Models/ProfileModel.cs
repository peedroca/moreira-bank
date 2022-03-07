using Flunt.Notifications;
using Flunt.Validations;

namespace MoreiraBank.Manager.Models
{
    internal class ProfileModel : Model
    {
        public ProfileModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotEmpty(FirstName, "Profile.FirstName")
                .IsNotEmpty(LastName, "Profile.FirstName")
                .IsNotEmpty(Email, "Profile.FirstName")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
    }
}

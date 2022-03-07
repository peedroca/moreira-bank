using Flunt.Notifications;
using Flunt.Validations;

namespace MoreiraBank.Manager.ValueObjects
{
    internal class Name : ValueObjectBase
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName => FirstName + " " + LastName;

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "FirstName")
                .IsNotNullOrEmpty(LastName, "LastName")
            );
        }
    }
}

using Flunt.Notifications;
using Flunt.Validations;

namespace MoreiraBank.Manager.ValueObjects
{
    internal class Email : ValueObjectBase
    {
        public string? Content { get; private set; }

        public Email(string? content, string field = "Email", int maxLenth = 100)
        {
            Content = content;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsLowerOrEqualsThan(Content?.Length ?? 0, maxLenth, field)
                .IsEmailOrEmpty(Content, field)
            );
        }
    }
}

using Flunt.Notifications;
using Flunt.Validations;
using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class SpendingModel : ModelBase
    {
        public SpendingModel(string description, decimal amount)
        {
            Description = description;
            Amount = amount;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Description, "Spending.Description")
            );
        }

        public string Description { get; set; }
        public decimal Amount { get; set; }

        public static implicit operator SpendingModel(Spending spending)
        {
            return new SpendingModel(spending.Description, spending.Amount);
        }
    }
}
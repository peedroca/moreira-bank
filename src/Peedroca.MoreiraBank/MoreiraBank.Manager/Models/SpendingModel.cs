using Flunt.Notifications;
using Flunt.Validations;
using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class SpendingModel : ModelBase
    {
        public SpendingModel(long spendingId, long profileId, string description, decimal amount)
        {
            SpendingId = spendingId;
            ProfileId = profileId;
            Description = description;
            Amount = amount;

            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNullOrEmpty(Description, "Description")
            );
        }

        public long SpendingId { get; private set; }
        public long ProfileId { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }

        public static implicit operator SpendingModel(Spending spending)
        {
            return new SpendingModel(spending.Idspending, spending.ProfileId, spending.Description, spending.Amount);
        }

        public static implicit operator Spending(SpendingModel spending)
        {
            return new Spending()
            {
                Description = spending.Description,
                Amount = spending.Amount,
                Idspending = int.Parse(spending.SpendingId.ToString()),
                ProfileId = int.Parse(spending.ProfileId.ToString()),
            };
        }
    }
}
using Flunt.Notifications;
using Flunt.Validations;
using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class EarningModel : ModelBase
    {
        public EarningModel(string description, decimal amount)
        {
            Description = description;
            Amount = amount;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Description, "Earning.Description")
            );
        }

        public string Description { get; set; }
        public decimal Amount { get; set; }

        public static implicit operator EarningModel(Earning earning)
        {
            return new EarningModel(earning.Description, earning.Amount);
        }
    }
}
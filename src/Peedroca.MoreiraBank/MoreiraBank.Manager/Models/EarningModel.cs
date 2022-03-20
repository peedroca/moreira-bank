using Flunt.Notifications;
using Flunt.Validations;
using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class EarningModel : ModelBase
    {
        public EarningModel(long earningId, long profileId, string description, decimal amount)
        {
            EarningId = earningId;
            ProfileId = profileId;
            Description = description;
            Amount = amount;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Description, "Description")
            );
        }

        public long EarningId { get; private set; }
        public long ProfileId { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }

        public static implicit operator EarningModel(Earning earning)
        {
            return new EarningModel(earning.Idearning, earning.ProfileId, earning.Description, earning.Amount);
        }

        public static implicit operator Earning(EarningModel earning)
        {
            return new Earning()
            {
                Idearning = int.Parse(earning.EarningId.ToString()),
                Amount = earning.Amount,
                Description = earning.Description,
                ProfileId = int.Parse(earning.ProfileId.ToString()),
            };
        }
    }
}
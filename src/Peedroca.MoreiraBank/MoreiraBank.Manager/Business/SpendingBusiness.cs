using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class SpendingBusiness
    {
        private readonly SpendingRepository _spendingRepository;

        public SpendingBusiness()
        {
            _spendingRepository = new SpendingRepository();
        }

        public Response<SpendingModel> Create(SpendingModel model)
        {
            if (!model.IsValid)
                return new Response<SpendingModel>(model.Notifications);

            Spending spending = model;

            _spendingRepository.Create(spending);
            _spendingRepository.SaveChanges();

            return new Response<SpendingModel>(spending);
        }

        public IEnumerable<SpendingModel> List(long profileId)
        {
            return _spendingRepository.GetAll(profileId).Select(s => (SpendingModel)s);
        }
    }
}

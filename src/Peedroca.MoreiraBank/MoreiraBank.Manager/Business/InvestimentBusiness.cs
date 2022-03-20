using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class InvestimentBusiness
    {
        private readonly InvestimentRepository _investimentRepository;

        public InvestimentBusiness()
        {
            _investimentRepository = new InvestimentRepository();
        }

        public IEnumerable<InvestimentModel> GetInvestiments(long profileId)
        {
            return _investimentRepository.GetAll(profileId).Select(e => (InvestimentModel)e);
        }
    }
}

using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class EstimatedInvestmentBusiness
    {
        private readonly EstimatedInvestmentRepository _estimatedInvestimentRepository;

        public EstimatedInvestmentBusiness()
        {
            _estimatedInvestimentRepository = new EstimatedInvestmentRepository();
        }

        public IEnumerable<EstimatedInvestmentModel> GetEstimatedInvestments(long profileId)
        {
            return _estimatedInvestimentRepository.GetAll(profileId).Select(e => (EstimatedInvestmentModel)e);
        }
    }
}

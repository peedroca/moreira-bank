using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class FinanceBusiness
    {
        private readonly SpendingRepository _spendingRepository;
        private readonly EarningRepository _earningRepository;
        private readonly EstimatedInvestmentRepository _estimatedInvestimentRepository;
        private readonly InvestimentRepository _investimentRepository;

        public FinanceBusiness()
        {
            _spendingRepository = new SpendingRepository();
            _earningRepository = new EarningRepository();
            _estimatedInvestimentRepository = new EstimatedInvestmentRepository();
            _investimentRepository = new InvestimentRepository();
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

        public IEnumerable<SpendingModel> GetSpendings(long profileId)
        {
            return _spendingRepository.GetAll(profileId).Select(s => (SpendingModel)s);
        }

        public IEnumerable<EarningModel> GetEarnings(long profileId)
        {
            return _earningRepository.GetAll(profileId).Select(e => (EarningModel)e);
        }

        public IEnumerable<EstimatedInvestmentModel> GetEstimatedInvestments(long profileId)
        {
            return _estimatedInvestimentRepository.GetAll(profileId).Select(e => (EstimatedInvestmentModel)e);
        }

        public IEnumerable<InvestimentModel> GetInvestiments(long profileId)
        {
            return _investimentRepository.GetAll(profileId).Select(e => (InvestimentModel)e);
        }
    }
}

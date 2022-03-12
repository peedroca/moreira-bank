using MoreiraBank.Manager.Business;
using MoreiraBank.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Facades
{
    internal class FinanceFacade
    {
        private FinanceModel? financeModel;
        private readonly long profileId;

        public FinanceFacade(long profileId)
        {
            this.profileId = profileId;
        }

        public List<SpendingModel>? GetSpending()
        {
            var business = new FinanceBusiness();
            var spendings = business.GetSpendings(profileId)?.ToList();

            if (financeModel == null)
                financeModel = new FinanceModel();

            if (spendings != null && spendings.Count > 0)
            {
                financeModel.AddSpending(spendings.ToArray());
                return spendings;
            }

            return default;
        }

        public List<EarningModel>? GetEarning()
        {
            var business = new FinanceBusiness();
            var earnings = business.GetEarnings(profileId)?.ToList();

            if (financeModel == null)
                financeModel = new FinanceModel();

            if (earnings != null && earnings.Count > 0)
            {
                financeModel.AddEarnings(earnings.ToArray());
                return earnings;
            }

            return default;
        }

        public List<EstimatedInvestmentModel>? GetEstimatedInvestments()
        {
            var business = new FinanceBusiness();
            var estimatedInvestments = business.GetEstimatedInvestments(profileId)?.ToList();

            if (financeModel == null)
                financeModel = new FinanceModel();

            if (estimatedInvestments != null && estimatedInvestments.Count > 0)
            {
                financeModel.AddEstimatedInvestiment(estimatedInvestments.ToArray());
                return estimatedInvestments;
            }

            return default;
        }

        public List<InvestimentModel>? GetInvestiments()
        {
            var business = new FinanceBusiness();
            var investiments = business.GetInvestiments(profileId)?.ToList();

            if (financeModel == null)
                financeModel = new FinanceModel();

            if (investiments != null && investiments.Count > 0)
            {
                financeModel.AddInvestiments(investiments.ToArray());
                return investiments;
            }

            return default;
        }

        public FinanceModel? GetFinance() => financeModel;
    }
}

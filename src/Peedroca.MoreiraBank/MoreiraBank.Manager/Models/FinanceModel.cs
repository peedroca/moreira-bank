using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Models
{
    internal class FinanceModel : ModelBase
    {
        private List<SpendingModel> spendingModels;
        private List<EarningModel> earningModels;
        private List<EstimatedInvestmentModel> estimatedInvestmentModels;
        private List<InvestimentModel> investimentModels;

        public FinanceModel()
        {
            spendingModels = new List<SpendingModel>();
            earningModels = new List<EarningModel>();
            estimatedInvestmentModels = new List<EstimatedInvestmentModel>();
            investimentModels = new List<InvestimentModel>();
        }
        
        public IReadOnlyCollection<SpendingModel> SpendingModels => spendingModels.AsReadOnly();
        public IReadOnlyCollection<EarningModel> EarningModels => earningModels.AsReadOnly();
        public IReadOnlyCollection<EstimatedInvestmentModel> EstimatedInvestmentModels => estimatedInvestmentModels.AsReadOnly();
        public IReadOnlyCollection<InvestimentModel> InvestimentModels => investimentModels.AsReadOnly();

        public void AddSpending(params SpendingModel[] spendings)
        {
            AddNotifications(spendings);
            spendingModels.AddRange(spendings);
        }

        public void AddEarnings(params EarningModel[] earnings)
        {
            AddNotifications(earnings);
            earningModels.AddRange(earnings);
        }

        public void AddEstimatedInvestiment(params EstimatedInvestmentModel[] estimatedInvestments)
        {
            AddNotifications(estimatedInvestments);
            estimatedInvestmentModels.AddRange(estimatedInvestments);
        }

        public void AddInvestiments(params InvestimentModel[] investiments)
        {
            AddNotifications(investiments);
            investimentModels.AddRange(investiments);
        }
    }
}

using MoreiraBank.Manager.Data;
using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Models
{
    internal class InvestimentModel : ModelBase
    {
        public InvestimentModel(string description, DateTime startDate, DateTime? endDate, decimal amount, decimal estimatedProfit)
        {
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Amount = amount;
            EstimatedProfit = estimatedProfit;
        }

        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Amount { get; set; }
        public decimal EstimatedProfit { get; set; }

        public static implicit operator InvestimentModel(Investiment investiment)
        {
            return new InvestimentModel(investiment.Description,
                                        investiment.StartDate,
                                        investiment.EndDate,
                                        investiment.Amount,
                                        investiment.EstimatedProfit);
        }
    }
}

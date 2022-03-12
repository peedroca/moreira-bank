using MoreiraBank.Manager.Data;
using System;
using System.Collections.Generic;

namespace MoreiraBank.Manager.Models
{
    internal class EstimatedInvestmentModel : ModelBase
    {
        public EstimatedInvestmentModel(decimal amount, CalendarModel? calendar)
        {
            Amount = amount;
            Calendar = calendar;
        }

        public decimal Amount { get; private set; }
        public CalendarModel? Calendar { get; private set; }

        public static implicit operator EstimatedInvestmentModel(EstimatedInvestment estimatedInvestment)
        {
            return new EstimatedInvestmentModel(estimatedInvestment.Amount, estimatedInvestment.Calendar);
        }
    }
}

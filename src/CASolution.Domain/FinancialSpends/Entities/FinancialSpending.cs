using CASolution.Domain.FinancialSpends.ValueObjects;
using CASolution.SharedKernel.Entities;
using System;

namespace CASolution.Domain.FinancialSpends.Entities
{
    public class FinancialSpending : BaseEntity
    {
        public int ProjectId { get; set; }
        public DateTime ExpectedSpendingDate { get; set; }
        public string CostType { get; set; }
        public string Description { get; set; }
        public Money LocalPurchase { get; set; }
        public Money ExternalPurchase { get; set; }

        #region  Constructors
        public FinancialSpending()
        {

        }

        public FinancialSpending(
            int projectId,
            int localPurchase,
            Money externalPurchase,
            string costType,
            string description,
            DateTime expectedSpendingDate)
        {
            ProjectId = projectId;
            LocalPurchase = localPurchase;
            ExternalPurchase = externalPurchase;
            CostType = costType;
            Description = description;
            ExpectedSpendingDate = expectedSpendingDate;
        }
        #endregion  Constructors


    }
}

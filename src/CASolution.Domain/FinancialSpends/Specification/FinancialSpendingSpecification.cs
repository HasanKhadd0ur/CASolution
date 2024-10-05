using CASolution.Domain.FinancialSpends.Entities;
using CASolution.SharedKernel.Specification;
using System;
using System.Linq.Expressions;


namespace PSManagement.Domain.FinancialSpends.Specification
{
    public class FinancialSpendingSpecification : BaseSpecification<FinancialSpending>
    {
        public FinancialSpendingSpecification(Expression<Func<FinancialSpending, bool>> criteria = null) : base(criteria)
        {

        }
    
    }
}

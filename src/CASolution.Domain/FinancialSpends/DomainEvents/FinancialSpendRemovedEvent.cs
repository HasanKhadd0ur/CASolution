using CASolution.SharedKernel.DomainEvents;
using System;

namespace CASolution.Domain.FinancialSpends.DomainEvents
{
    public record FinancialSpendRemovedEvent(
        int FinancialSpendItemId,
        DateTime CancellationTime) : IDomainEvent;
}

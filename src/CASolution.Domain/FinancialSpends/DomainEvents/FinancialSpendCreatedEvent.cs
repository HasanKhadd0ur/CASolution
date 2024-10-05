using CASolution.SharedKernel.DomainEvents;

namespace CASolution.Domain.FinancialSpends.DomainEvents
{
    public record FinancialSpendCreatedEvent(
        int FinancialSpendId) : IDomainEvent;
}

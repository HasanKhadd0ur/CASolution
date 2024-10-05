using System;
using CASolution.SharedKernel.DomainEvents;

namespace CASolution.Domain.FinancialSpends.DomainEvents
{
    public record FinancialSpendChangedEvent(
        int ParticipantId,
        int PartialTimeRatioBefore,
        int PartialTimeRatioAfter,
        string RoleBefore,
        string RoleAfter,
        int ProjectId,
        DateTime DateTime
        ) : IDomainEvent;
}

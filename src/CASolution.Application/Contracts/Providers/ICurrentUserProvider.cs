using System.Collections.Generic;

namespace CASolution.Application.Contracts.Providers
{
    public interface ICurrentUserProvider
    {
        int? EmployeeId { get; }
        string Email { get; }
        int? HiastId { get; }
        IEnumerable<string> Roles { get; }
    }
}

using System;

namespace CASolution.Application.Contracts.Providers
{
    public interface IDateTimeProvider
    {
        public DateTime UtcNow { get; }
    }

}

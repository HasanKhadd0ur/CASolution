using System.Reflection;

namespace CASolution.Infrastructure.Persistence.AssemblyReference
{
    public class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;

    }
}

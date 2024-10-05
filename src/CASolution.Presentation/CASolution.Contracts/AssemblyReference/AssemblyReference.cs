using System.Reflection;

namespace CASolution.Contracts.AssemblyReference
{
    public class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;

    }
}

using GenericsLab.Common.Abstractions;

namespace GenericsLab.WithoutDI;

public class ResolverClient
{
    public TResult UseResolver<TResult>(IResolver<TResult> resolver)
    {
        return resolver.Resolve();
    }
}
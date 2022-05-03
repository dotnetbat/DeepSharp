using GenericsLab.Common.Abstractions;

namespace GenericsLab.WithDI;

public class ResolverClient<TResult>
{
    private readonly IResolver<TResult> _resolver;

    public ResolverClient(IResolver<TResult> resolver)
    {
        _resolver = resolver;
    }
    
    public TResult UseResolver()
    {
        return _resolver.Resolve();
    }
}
using GenericsLab.Common;
using GenericsLab.Common.Abstractions;

namespace GenericsLab.Factory;

public class FactoryClient
{
    public TResult UseFactory<TResult>()
    {
        var resolver = ResolverFactory.CreateResolver<TResult>();

        return resolver.Resolve();
    }
}
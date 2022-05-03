namespace GenericsLab.WithDI;

public class Service<TResult>
{
    private readonly ResolverClient<TResult> _resolverClient;

    public Service(ResolverClient<TResult> resolverClient)
    {
        _resolverClient = resolverClient;
    }

    public TResult Method()
    {
        return _resolverClient.UseResolver();
    }
}
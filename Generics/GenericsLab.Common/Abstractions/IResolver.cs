namespace GenericsLab.Common.Abstractions;

public interface IResolver<TResult>
{
    public TResult Resolve();
}
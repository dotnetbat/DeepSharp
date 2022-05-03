using System.Net.NetworkInformation;
using GenericsLab.Common;
using GenericsLab.Common.Abstractions;
using GenericsLab.Common.Resolvers;

namespace GenericsLab.Factory;

internal static class ResolverFactory
{
    public static IResolver<TResult> CreateResolver<TResult>()
    {
        if (typeof(TResult) == typeof(int))
        {
            return (IResolver<TResult>) new IntResolver();
        }

        if (typeof(TResult) == typeof(string))
        {
            return (IResolver<TResult>) new StringResolver();
        }
        
        if (typeof(TResult) == typeof(DateTime))
        {
            return (IResolver<TResult>) new DateTimeResolver();
        }

        throw new NetworkInformationException();
    }
}
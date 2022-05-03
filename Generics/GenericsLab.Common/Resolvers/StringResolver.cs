using GenericsLab.Common.Abstractions;

namespace GenericsLab.Common.Resolvers;

public class StringResolver : IResolver<string>
{
    public string Resolve()
    {
        return "Doopa";
    }
}
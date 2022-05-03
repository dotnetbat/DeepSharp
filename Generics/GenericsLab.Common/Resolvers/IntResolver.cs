using GenericsLab.Common.Abstractions;

namespace GenericsLab.Common.Resolvers;

public class IntResolver : IResolver<int>
{
    public int Resolve()
    {
        return 13;
    }
}
using GenericsLab.Common.Abstractions;

namespace GenericsLab.Common.Resolvers;

public class DateTimeResolver : IResolver<DateTime>
{
    public DateTime Resolve()
    {
        return DateTime.Now;
    }
}
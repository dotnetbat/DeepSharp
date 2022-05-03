using GenericsLab.Common;
using GenericsLab.Common.Enums;

namespace GenericsLab.Legacy;

public class LegacyService
{
    public object UseLegacyService(ResolverType resolverType)
    {
        switch (resolverType)
        {
            case ResolverType.DateTime:
                return DateTime.Now;
            case ResolverType.Int:
                return 13;
            case ResolverType.String:
                return string.Empty;
            default:
                throw new ArgumentOutOfRangeException(nameof(resolverType), resolverType, null);
        }
        
        // return resolverType switch
        // {
        //     ResolverType.DateTime => DateTime.Now,
        //     ResolverType.Int => 13,
        //     ResolverType.String => string.Empty,
        //     _ => throw new ArgumentOutOfRangeException(nameof(resolverType), resolverType, null)
        // };
    }
}
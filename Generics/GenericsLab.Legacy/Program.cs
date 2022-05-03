using GenericsLab.Common.Enums;
using GenericsLab.Legacy;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var legacyService = new LegacyService();

var result = legacyService.UseLegacyService(ResolverType.DateTime);

app.MapGet("/", () => (DateTime)result);

app.Run();
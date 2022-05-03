using GenericsLab.Common.Resolvers;
using GenericsLab.WithoutDI;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var resolverClient = new ResolverClient();

var resolverResult = resolverClient.UseResolver(new IntResolver());

app.MapGet("/", () => resolverResult);

app.Run();
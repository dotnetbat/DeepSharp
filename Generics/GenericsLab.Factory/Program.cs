using GenericsLab.Common;
using GenericsLab.Factory;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var factoryClient = new FactoryClient();

var result = factoryClient.UseFactory<DateTime>();

app.MapGet("/", () => result);

app.Run();
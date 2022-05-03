using GenericsLab.Common;
using GenericsLab.Common.Abstractions;
using GenericsLab.Common.Resolvers;
using GenericsLab.WithDI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IResolver<DateTime>, DateTimeResolver>();
builder.Services.AddTransient<IResolver<int>, IntResolver>();
builder.Services.AddTransient<IResolver<string>, StringResolver>();

builder.Services.AddTransient(typeof(ResolverClient<>));
builder.Services.AddTransient(typeof(Service<>));

var app = builder.Build();

//////////////// В обычном случае мы не вызываем GetService напрямую
var service = app.Services.GetService<Service<int>>();

//////////////// Где-то в коде
var result = service.Method();

app.MapGet("/", () => result);

app.Run();
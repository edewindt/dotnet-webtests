var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<CustomMiddleware>();
var app = builder.Build();

app.Use(async (ctx, next) =>
{
    await ctx.Response.WriteAsync("You suck ");
    await next(ctx);
});
app.DoSomething();
app.DoIt();
app.Run(async (ctx) =>
{
    await ctx.Response.WriteAsync("Third");
});

app.Run();

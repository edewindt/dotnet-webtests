var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<CustomMiddleware>();
var app = builder.Build();

app.UseWhen(ctx => ctx.Request.Query.ContainsKey("user"),
    app =>
    {
        app.Use(async (ctx, next) =>
        {
            var namae = ctx.Request.Query["user"];
            await ctx.Response.WriteAsync($"{namae}");
            await next();
        });

    });
app.DoIt();


app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("first/{name=Ger}", async (ctx) =>
    {
        var firstname = Convert.ToString(ctx.Request.RouteValues["name"]);
        await ctx.Response.WriteAsync($"{firstname}");
    });
});
app.Run();

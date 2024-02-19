var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("first/{name},{secondname}", async (ctx) =>
    {
        var firstname = Convert.ToString(ctx.Request.RouteValues["name"]);
        var secondname = Convert.ToString(ctx.Request.RouteValues["secondname"]);
        await ctx.Response.WriteAsync($"{firstname} {secondname}");
    });
});
app.Run();

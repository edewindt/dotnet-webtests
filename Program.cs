var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("first/{age:int:length(3,10)=6989}", async (ctx) =>
    {
        var age = Convert.ToInt32(ctx.Request.RouteValues["age"]);
        await ctx.Response.WriteAsync($"{age}");
    });
});
app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (ctx) =>
{
    //Status Code
    ctx.Response.StatusCode = 200;
    //Response Header
    ctx.Response.Headers["Key"] = "Value";
    ctx.Response.Headers["Content-Type"] = "text/html";
    //Request Properties
    string path = ctx.Request.Path;
    string method = ctx.Request.Method;
    if (ctx.Request.Query.ContainsKey("id"))
    {
        string? querystr = ctx.Request.Query["id"];
        await ctx.Response.WriteAsync($"{querystr}");
    }
    string? val = Convert.ToString(ctx.Request.RouteValues["name"]);

    var reader = new StreamReader(ctx.Request.Body);
    string bod = await reader.ReadToEndAsync();
    //Final Response
    await ctx.Response.WriteAsync($"{val}");
});

app.Run();

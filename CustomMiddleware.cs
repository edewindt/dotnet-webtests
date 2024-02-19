
class CustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext ctx, RequestDelegate next)
    {
        await ctx.Response.WriteAsync("Custom Middleware");
        await next(ctx);
        await ctx.Response.WriteAsync("Ending Custom");
    }
}

static class CustomMiddlewareExtension
{
    public static IApplicationBuilder DoSomething(this IApplicationBuilder app)
    {
        return app.UseMiddleware<CustomMiddleware>();
    }
}
class ConventionalMiddleware
{
    private readonly RequestDelegate _next;
    public ConventionalMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext httpContext)
    {
        await httpContext.Response.WriteAsync("The convetional");
        await _next(httpContext);
    }
}

static class ConventionalMiddlewareExtension
{
    public static IApplicationBuilder DoIt(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ConventionalMiddleware>();
    }
}
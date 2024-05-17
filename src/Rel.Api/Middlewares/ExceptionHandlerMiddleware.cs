
namespace Rel.Api.Middlewares;

public class ExceptionHandlerMiddleware : IMiddleware
{
    private readonly ILogger _logger;
    public ExceptionHandlerMiddleware(ILogger logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
        }
        throw new NotImplementedException();
    }
}

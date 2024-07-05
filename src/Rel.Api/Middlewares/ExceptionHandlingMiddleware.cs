namespace Rel.Api.Middlewares;

public class ExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;
    public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "An unhandled exception occurred.");

            await HandleExceptionAsync(context, exception);    
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        // Log the exception
        var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();

        // Write the error details to a text file
        var logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "logs");
        var logFileName = $"error_{DateTime.Now:yyyyMMMMdd_HHmmss}.txt";
        var logFilePath = Path.Combine(logDirectory, logFileName);
        Directory.CreateDirectory(logDirectory); // Ensure the directory exists
        using (var writer = new StreamWriter(logFilePath))
        {
            await writer.WriteLineAsync($"Timestamp: {DateTime.Now}");
            await writer.WriteLineAsync($"Error: {exception?.Message}");
            await writer.WriteLineAsync($"StackTrace: {exception?.StackTrace}");
            // Add more details as needed
        }

        // Return an appropriate response to the client
        context.Response.StatusCode = GetStatusCode(exception);
        context.Response.ContentType = "application/json";
            var failResponse = exception.Message;// new FailResponse<string>(exception.Message);

        var serializerSettings = new JsonSerializerSettings();
        serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        var jsonReponse = JsonConvert.SerializeObject(failResponse, serializerSettings);

        await context.Response.WriteAsync(jsonReponse);
    }

    private static int GetStatusCode(Exception exception) =>
        exception switch
        {
            BadRequestException => StatusCodes.Status400BadRequest,
            NotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError,
        };
}

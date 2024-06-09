using Microsoft.Extensions.Logging;
using Serilog;

namespace Rel.Presentation.APIs;

public class UserApi
{
    private readonly ILogger<UserApi> _logger;
    public UserApi(ILogger<UserApi> logger)
    {
        _logger = logger;
    }
    public static async Task<IResult> CreateUser()
    {
        return Results.Ok();
    }
    public static async Task<IResult> GetUser(Guid id)
    {
        return Results.Ok();
    }
    public static async Task<IResult> DeleteUser(Guid id)
    {
        return Results.Ok();
    }
    public static async Task<string> HelloWorld(string name)
    {
        Log.Information("test result !");
        return "hello world " + name;
    }
}

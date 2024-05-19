namespace Rel.Presentation.APIs;

public static class UserApi
{
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
        return "hello world " + name;
    }
}

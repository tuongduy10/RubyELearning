
namespace Rel.Presentation.Endpoints.Users;

public class UserEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/users");

        group.MapPost("/create-user", () => "");
        group.MapPost("/get-user/{id}", () => "");
        group.MapPost("/update-update", () => "");
        group.MapDelete("/delete-user/{id}", () => "");
        group.MapPost("/login", UserApi.HelloWorld);
    }
}


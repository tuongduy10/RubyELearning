namespace Rel.Api.Endpoints
{
    public class ProductsEndpoints: ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/products").RequireAuthorization();

            group.MapPost("/create-product", CreateProducts);
            group.MapPost("/get-product/{id}", GetProduct);
            group.MapPost("/update-product", CreateProducts);
            group.MapDelete("/delete-product/{id}", DeleteProduct);
        }

        // Move these controller functions to PRESENTATION
        public static async Task<IResult> CreateProducts()
        {
            return Results.Ok();
        }
        public static async Task<IResult> GetProduct(Guid id)
        {
            return Results.Ok();
        }
        public static async Task<IResult> DeleteProduct(Guid id)
        {
            return Results.Ok();
        }
    }
}

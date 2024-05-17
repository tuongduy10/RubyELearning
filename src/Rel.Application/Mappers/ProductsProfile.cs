namespace Rel.Application.Mappers;

public class ProductsProfile : Profile
{
    public ProductsProfile()
    {
        CreateMap<string, string>().ReverseMap();
    }
}

namespace Rel.Contract.Abstractions.Messages;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}

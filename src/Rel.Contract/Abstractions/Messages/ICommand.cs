﻿namespace Rel.Contract.Abstractions.Messages;

public interface ICommand : IRequest<Result>
{
}
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
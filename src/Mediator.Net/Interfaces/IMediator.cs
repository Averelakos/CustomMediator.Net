using Mediator.Net.Interfaces.Input;

namespace Mediator.Net.Interfaces
{
    public interface IMediator
    {
        Task<object?> Send(object request, CancellationToken cancellationToken = default);
        //Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
        Task<TRequest> Sent<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest;
    }
}

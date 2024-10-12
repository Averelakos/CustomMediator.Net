using Mediator.Net.Interfaces.Input;

namespace Mediator.Net.Interfaces.Handlers
{
    public interface IRequestHandler<in TRequest> where TRequest : IRequest 
    {
        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Response from the request</returns>
        Task Handle(TRequest request, CancellationToken cancellationToken);
    }
}

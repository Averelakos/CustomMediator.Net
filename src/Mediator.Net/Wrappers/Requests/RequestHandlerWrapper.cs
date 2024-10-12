using Mediator.Net.Handlers.Requests;
using Mediator.Net.Interfaces.Input;

namespace Mediator.Net.Wrappers.Requests
{
    public abstract class RequestHandlerWrapper : RequestHandlerBase
    {
        public abstract Task<VoidType> Handle(IRequest request, IServiceProvider serviceProvider, CancellationToken ct);
    }
}

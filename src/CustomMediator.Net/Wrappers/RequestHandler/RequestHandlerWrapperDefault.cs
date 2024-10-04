using CustomMediator.Net.Contracts;

namespace CustomMediator.Net.Wrappers.RequestHandler
{
    public abstract class RequestHandlerWrapperDefault : RequestHandlerBase
    {
        public abstract Task<CustomVoid> Handle(IRequest request, IServiceProvider serviceProvider,
            CancellationToken cancellationToken);
    }
}

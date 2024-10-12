namespace Mediator.Net.Handlers.Requests
{
    public abstract class RequestHandlerBase
    {
        public abstract Task<object?> Handle(object request, IServiceProvider serviceProvider, CancellationToken ct);
    }
}

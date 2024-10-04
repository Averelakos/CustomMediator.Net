using CustomMediator.Net.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CustomMediator.Net.Wrappers.RequestHandler
{
    public abstract class RequestHandlerBase
    {
        public abstract Task<object?> HandleRequest(object request, IServiceProvider serviceProvider, CancellationToken ct);
    }

    //public class RequestHandlerWrapperDefaultImpl<TRequest> : RequestHandlerWrapperDefault where TRequest : IRequest
    //{
    //    public override async Task<object?> HandleRequest(object request, IServiceProvider serviceProvider,
    //        CancellationToken cancellationToken) =>
    //        await Handle((IRequest)request, serviceProvider, cancellationToken).ConfigureAwait(false);

    //    public override Task<CustomVoid> Handle(IRequest request, IServiceProvider serviceProvider,
    //        CancellationToken cancellationToken)
    //    {
    //        async Task<CustomVoid> Handler(CancellationToken t = default)
    //        {
    //            await serviceProvider.GetRequiredService<IRequestHandler<TRequest>>()
    //                .Handle((TRequest)request, t == default ? cancellationToken : t);

    //            return CustomVoid.Value;
    //        }

    //        return serviceProvider
    //            .GetServices<IPipelineBehavior<TRequest, CustomVoid>>()
    //            .Reverse()
    //            .Aggregate((RequestHandlerDelegate<CustomVoid>)Handler,
    //                (next, pipeline) => (t) => pipeline.Handle((TRequest)request, next, t == default ? cancellationToken : t))();
    //    }
    //}
}

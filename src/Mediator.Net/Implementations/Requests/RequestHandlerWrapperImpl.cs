using Mediator.Net.Interfaces.Input;
using Mediator.Net.Wrappers.Requests;

namespace Mediator.Net.Implementations.Requests
{
    public class RequestHandlerWrapperImpl : RequestHandlerWrapper
    {
        public override async Task<object?> Handle(object request, IServiceProvider serviceProvider, CancellationToken ct)
        {
            return await Handle((IRequest)request, serviceProvider, ct).ConfigureAwait(false);
        }

        public override Task<VoidType> Handle(IRequest request, IServiceProvider serviceProvider, CancellationToken ct)
        {
            async Task<VoidType> Test() 
            {
                return VoidType.Value;
            }
            throw new NotImplementedException();
        }        
    }
}

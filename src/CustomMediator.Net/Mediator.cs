using CustomMediator.Net.Contracts;

namespace CustomMediator.Net
{
    public class Mediator : IMediator
    {
        public Task<object?> Send(object request, CancellationToken ct = default)
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            return null;
        }
    }
}

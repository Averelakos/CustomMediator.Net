using Mediator.Net.Handlers.Requests;
using Mediator.Net.Interfaces;
using Mediator.Net.Interfaces.Input;
using System.Collections.Concurrent;

namespace Mediator.Net
{
    public class MediatorNet : IMediator
    {
        private readonly ConcurrentDictionary<Type, RequestHandlerBase> _requestHandler = new ();
        //private Component1 _component1;

        //private Component2 _component2;

        //public Mediator(Component1 component1, Component2 component2)
        //{
        //    this._component1 = component1;
        //    this._component1.SetMediator(this);
        //    this._component2 = component2;
        //    this._component2.SetMediator(this);
        //}

        //public void Notify(object sender, string ev)
        //{
        //    if (ev == "A")
        //    {
        //        Console.WriteLine("Mediator reacts on A and triggers following operations:");
        //        this._component2.DoC();
        //    }
        //    if (ev == "D")
        //    {
        //        Console.WriteLine("Mediator reacts on D and triggers following operations:");
        //        this._component1.DoB();
        //        this._component2.DoC();
        //    }
        //}
        public Task<object?> Send(object request, CancellationToken cancellationToken = default)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            var handler = _requestHandler.GetOrAdd(request.GetType(), static requestType =>
            {

                Type typeWrapper;



                var wrapper = Activator.CreateInstance(typeWrapper) ?? throw new InvalidOperationException($"Could not create wrapper for type {requestType}");
                return (RequestHandlerBase)new object();
            });

            return handler.Handle(request);
        }

        //public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TRequest> Sent<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
        //{
        //    throw new NotImplementedException();
        //}
    }
}

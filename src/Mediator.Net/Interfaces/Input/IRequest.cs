namespace Mediator.Net.Interfaces.Input
{
    /// <summary>
    /// Interface to represent a request with void response
    /// </summary>
    public interface IRequest { }

    /// <summary>
    /// Interface to represent a request with a response
    /// </summary>
    /// <typeparam name="TResponse">Response type</typeparam>
    public interface IResponse<out TResponse> { }
}

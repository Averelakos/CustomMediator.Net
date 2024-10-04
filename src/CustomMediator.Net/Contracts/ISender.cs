namespace CustomMediator.Net.Contracts
{
    public interface ISender
    {
        Task<object?> Send(object request, CancellationToken ct = default);
    }
}

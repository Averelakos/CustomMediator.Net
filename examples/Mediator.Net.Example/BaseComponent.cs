using Mediator.Net.Interfaces;
namespace CustomMediator.Example
{
    public class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator) 
        {
            _mediator = mediator;
        }

        public void Test()
        {
            object obj = new { Name = "Iraklis", Number = 1 };
            _mediator.Send(obj);
        }
    }
}

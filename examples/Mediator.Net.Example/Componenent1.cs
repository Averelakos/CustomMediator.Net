namespace CustomMediator.Example
{
    public class Componenent1: BaseComponent 
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            //this._mediator.Send(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            //this._mediator.Send(this, "B");
        }
    }
}

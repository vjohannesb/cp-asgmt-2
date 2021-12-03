namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Emphasized : HTMLDecoratorBase
    {
        public Emphasized(IDecorator decorator) : base(decorator)
        {
            Tag = "em";
        }
    }
}

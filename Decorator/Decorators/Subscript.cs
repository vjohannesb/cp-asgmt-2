namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Subscript : HTMLDecoratorBase
    {
        public Subscript(IDecorator decorator) : base(decorator)
        {
            Tag = "sub";
        }
    }
}

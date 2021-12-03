namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Bold : HTMLDecoratorBase
    {
        public Bold(IDecorator decorator) : base(decorator)
        {
            Tag = "b";
        }
    }
}

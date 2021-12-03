namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Smaller : HTMLDecoratorBase
    {
        public Smaller(IDecorator decorator) : base(decorator)
        {
            Tag = "small";
        }
    }
}

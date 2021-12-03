namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Marked : HTMLDecoratorBase
    {
        public Marked(IDecorator decorator) : base(decorator)
        {
            Tag = "mark";
        }
    }
}

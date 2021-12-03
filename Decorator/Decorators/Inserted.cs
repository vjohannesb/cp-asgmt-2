namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Inserted : HTMLDecoratorBase
    {
        public Inserted(IDecorator decorator) : base(decorator)
        {
            Tag = "ins";
        }
    }
}

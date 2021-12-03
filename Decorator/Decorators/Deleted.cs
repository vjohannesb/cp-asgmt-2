namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Deleted : HTMLDecoratorBase
    {
        public Deleted(IDecorator decorator) : base(decorator)
        {
            Tag = "del";
        }
    }
}

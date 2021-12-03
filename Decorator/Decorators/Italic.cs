namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Italic : HTMLDecoratorBase
    {
        public Italic(IDecorator decorator) : base(decorator)
        {
            Tag = "i";
        }
    }
}

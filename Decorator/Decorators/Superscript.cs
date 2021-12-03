namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Superscript : HTMLDecoratorBase
    {
        public Superscript(IDecorator decorator) : base(decorator)
        {
            Tag = "sup";
        }
    }
}

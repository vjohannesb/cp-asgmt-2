using Design_Patterns_Assignment.Decorator.Decorators;

namespace Design_Patterns_Assignment.Decorator
{
    internal class HTMLGenerator
    {
        internal static string TagProcessor(string tagSelection, string textInput)
        {
            IDecorator html = new HTMLBase(textInput);

            var taglist = tagSelection.ToLower().Split(' ');
            foreach (var tag in taglist)
            {
                switch (tag)
                {
                    case "bold":
                        html = new Bold(html);
                        break;
                    case "deleted":
                        html = new Deleted(html);
                        break;
                    case "emphasized":
                        html = new Emphasized(html);
                        break;
                    case "important":
                        html = new Important(html);
                        break;
                    case "inserted":
                        html = new Inserted(html);
                        break;
                    case "italic":
                        html = new Italic(html);
                        break;
                    case "marked":
                        html = new Marked(html);
                        break;
                    case "smaller":
                        html = new Smaller(html);
                        break;
                    case "subscript":
                        html = new Subscript(html);
                        break;
                    case "superscript":
                        html = new Superscript(html);
                        break;
                    default:
                        break;
                }
            }
            return html.GetHTML();
        }
    }
}
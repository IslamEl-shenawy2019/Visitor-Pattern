namespace Visitor_Pattern
{
    public class HeadingNode : IHtmlNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
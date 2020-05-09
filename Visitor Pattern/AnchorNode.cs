namespace Visitor_Pattern
{
    public class AnchorNode : IHtmlNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
using System.Collections.Generic;

namespace Visitor_Pattern
{
    public class HtmlDocument
    {
        private List<IHtmlNode> htmlNodes = new List<IHtmlNode>();
        public void Add(IHtmlNode node) 
        {
            htmlNodes.Add(node);
        }
        public void execute(IOperation operation) 
        {
            foreach (var node in htmlNodes)
            {
                node.execute(operation);
            }
        }
    }
}

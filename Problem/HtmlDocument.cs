using System.Collections.Generic;
namespace Problem
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _htmlNodes = new List<IHtmlNode>();
        public void Add(IHtmlNode htmlNode) 
        {
            _htmlNodes.Add(htmlNode);
        }
        public void HighlightAllNodes() 
        {
            foreach (var node in _htmlNodes)
            {
                node.Highlight();
            }
        }
    }
}

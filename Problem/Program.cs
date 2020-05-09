using System;
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.HighlightAllNodes();
        }
    }
}

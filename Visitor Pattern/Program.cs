using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            //document.HighlightAllNodes();
            document.execute(new HighlightOperation());
            document.execute(new PlainTextOperation());

        }
    }
}

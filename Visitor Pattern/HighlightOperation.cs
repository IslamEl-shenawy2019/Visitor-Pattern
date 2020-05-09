using System;

namespace Visitor_Pattern
{
    public class HighlightOperation : IOperation
    {
        public void apply(HeadingNode headingNode)
        {
            Console.WriteLine("Highlight Heading Node ...");
        }

        public void apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Highlight Anchor Node ...");
        }
    }
}

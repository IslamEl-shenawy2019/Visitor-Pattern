using System;

namespace Visitor_Pattern
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode headingNode)
        {
            Console.WriteLine("Plain Text of Heading Node ...");
        }

        public void apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Plain Text of Anchor Node ...");
        }
    }
}

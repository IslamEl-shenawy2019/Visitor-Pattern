namespace Visitor_Pattern
{
    public interface IOperation
    {
        void apply(HeadingNode headingNode);
        void apply(AnchorNode anchorNode);
    }
}

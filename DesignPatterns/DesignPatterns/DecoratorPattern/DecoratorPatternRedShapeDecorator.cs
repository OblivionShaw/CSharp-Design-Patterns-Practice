public class DecoratorPatternRedShapeDecorator : DecoratorPatternShapeDecorator
{
    public DecoratorPatternRedShapeDecorator(DecoratorPatternShape decoratedShape) : base(decoratedShape)
    {
    }

    public override string Draw()
    {
        return DecoratedShape.Draw() + "\n" + SetRedBorder(DecoratedShape);
    }

    private string SetRedBorder(DecoratorPatternShape decoratedShape)
    {
        return "Border Color: Red";
    }
}

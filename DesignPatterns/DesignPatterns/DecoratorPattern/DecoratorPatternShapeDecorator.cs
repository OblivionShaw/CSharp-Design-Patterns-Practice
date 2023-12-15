public abstract class DecoratorPatternShapeDecorator : DecoratorPatternShape
{
    protected DecoratorPatternShape DecoratedShape;

    public DecoratorPatternShapeDecorator(DecoratorPatternShape decoratedShape)
    {
        this.DecoratedShape = decoratedShape;
    }

    public virtual string Draw()
    {
        return DecoratedShape.Draw();
    }
}

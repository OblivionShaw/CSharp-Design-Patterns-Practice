public class AbstractFactoryPatternShapeFactory : AbstractFactoryPatternAbstractFactory
{
    public override AbstractFactoryPatternShape GetShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        else if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternCircle();
        }
        else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternRectangle();
        }
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternSquare();
        }
        return null;
    }

    public override AbstractFactoryPatternColor GetColor(string color)
    {
        return null;
    }
}
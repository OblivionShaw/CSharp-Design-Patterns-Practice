public class FactoryPatternShapeFactory
{
    public FactoryPatternShape GetShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        else if (shapeType.Equals("FactoryPatternCircle", StringComparison.OrdinalIgnoreCase))
        {
            return new FactoryPatternCircle();
        }
        else if (shapeType.Equals("FactoryPatternRectangle", StringComparison.OrdinalIgnoreCase))
        {
            return new FactoryPatternRectangle();
        }
        else if (shapeType.Equals("FactoryPatternSquare", StringComparison.OrdinalIgnoreCase))
        {
            return new FactoryPatternSquare();
        }
        return null;
    }
}
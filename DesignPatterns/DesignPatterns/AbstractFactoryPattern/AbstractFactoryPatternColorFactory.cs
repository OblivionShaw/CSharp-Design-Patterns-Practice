public class AbstractFactoryPatternColorFactory : AbstractFactoryPatternAbstractFactory
{
    public override AbstractFactoryPatternShape GetShape(string shapeType)
    {
        return null;
    }

    public override AbstractFactoryPatternColor GetColor(string color)
    {
        if (color == null)
        {
            return null;
        }
        else if (color.Equals("RED", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternRed();
        }
        else if (color.Equals("GREEN", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternGreen();
        }
        else if (color.Equals("BLUE", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternBlue();
        }
        return null;
    }
}

public class AbstractFactoryPatternFactoryProducer
{
    public static AbstractFactoryPatternAbstractFactory GetFactory(string choice)
    {
        if (choice.Equals("SHAPE", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternShapeFactory();
        }
        else if (choice.Equals("COLOR", StringComparison.OrdinalIgnoreCase))
        {
            return new AbstractFactoryPatternColorFactory();
        }
        return null;
    }
}
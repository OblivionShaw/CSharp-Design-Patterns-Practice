
using System.Collections;

public class PrototypePatternShapeCache
{
    private static Hashtable shapeMap = new Hashtable();

    public static PrototypePatternShape GetShape(string shapeId)
    {
        PrototypePatternShape cachedShape = (PrototypePatternShape)shapeMap[shapeId];
        return (PrototypePatternShape)cachedShape.Clone();
    }

    public static void LoadCache()
    {
        PrototypePatternCircle circle = new PrototypePatternCircle();
        circle.SetId("1");
        shapeMap[circle.GetId()] = circle;

        PrototypePatternSquare square = new PrototypePatternSquare();
        square.SetId("2");
        shapeMap[square.GetId()] = square;

        PrototypePatternRectangle rectangle = new PrototypePatternRectangle();
        rectangle.SetId("3");
        shapeMap[rectangle.GetId()] = rectangle;
    }
}

public class PrototypePatternRectangle : PrototypePatternShape
{
    public PrototypePatternRectangle()
    {
        type = "Rectangle";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Rectangle::draw() method.");
    }
}


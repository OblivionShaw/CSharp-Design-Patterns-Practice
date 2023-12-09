public class PrototypePatternCircle : PrototypePatternShape
{
    public PrototypePatternCircle()
    {
        type = "Circle";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Circle::draw() method.");
    }
}

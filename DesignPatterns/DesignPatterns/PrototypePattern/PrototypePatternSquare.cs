public class PrototypePatternSquare : PrototypePatternShape
{
    public PrototypePatternSquare()
    {
        type = "Square";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Square::draw() method.");
    }
}

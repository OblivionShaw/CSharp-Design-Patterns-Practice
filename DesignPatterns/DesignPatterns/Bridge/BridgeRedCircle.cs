public class BridgeRedCircle : BridgeDrawAPI
{
    public string DrawCircle(int radius, int x, int y)
    {
        return "Drawing Circle[ color: red, radius: "
            + radius + ", x: " + x + ", " + y + "]";
    }
}
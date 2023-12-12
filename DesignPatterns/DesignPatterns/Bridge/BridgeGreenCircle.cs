public class BridgeGreenCircle : BridgeDrawAPI
{
    public string DrawCircle(int radius, int x, int y)
    {
        return "Drawing Circle[ color: green, radius: "
            + radius + ", x: " + x + ", " + y + "]";
    }
}
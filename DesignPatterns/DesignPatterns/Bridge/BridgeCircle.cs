public class BridgeCircle : BridgeShape
{
    private int x, y, radius;

    public BridgeCircle(int x, int y, int radius, BridgeDrawAPI drawAPI) : base(drawAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override string Draw()
    {
        return drawAPI.DrawCircle(radius, x, y);
    }
}
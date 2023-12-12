public abstract class BridgeShape
{
    protected BridgeDrawAPI drawAPI;
    protected BridgeShape(BridgeDrawAPI drawAPI)
    {
        this.drawAPI = drawAPI;
    }
    public abstract string Draw();
}
public abstract class PrototypePatternShape : ICloneable
{
    private string id;
    protected string type;

    public abstract void Draw();

    public string GetType()
    {
        return type;
    }

    public string GetId()
    {
        return id;
    }

    public void SetId(string id)
    {
        this.id = id;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

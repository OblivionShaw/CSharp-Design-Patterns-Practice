public class BuilderPatternVegBurger : BuilderPatternBurger
{
    public override float price()
    {
        return 25.0f;
    }

    public override string name()
    {
        return "素食漢堡";
    }
}

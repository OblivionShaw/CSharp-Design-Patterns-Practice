public abstract class BuilderPatternBurger : BuilderPatternItem
{
    public override BuilderPatternPacking packing()
    {
        return new BuilderPatternWrapper();
    }

    public abstract override float price();
}
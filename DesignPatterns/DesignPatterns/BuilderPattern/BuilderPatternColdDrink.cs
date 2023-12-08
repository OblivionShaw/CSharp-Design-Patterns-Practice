public abstract class BuilderPatternColdDrink : BuilderPatternItem
{
    public override BuilderPatternPacking packing()
    {
        return new BuilderPatternBottle();
    }

    public abstract override float price();
}
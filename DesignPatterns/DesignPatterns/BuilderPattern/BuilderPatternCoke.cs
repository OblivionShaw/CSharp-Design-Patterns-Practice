public class BuilderPatternCoke : BuilderPatternColdDrink
{
    public override float price()
    {
        return 30.0f;
    }

    public override string name()
    {
        return "不可樂";
    }
}

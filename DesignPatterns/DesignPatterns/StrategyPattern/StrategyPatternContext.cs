public class StrategyPatternContext
{
    private StrategyPatternStrategy strategy;

    public StrategyPatternContext(StrategyPatternStrategy strategy)
    {
        this.strategy = strategy;
    }

    public int ExecuteStrategy(int num1, int num2)
    {
        return strategy.DoOperation(num1, num2);
    }
}
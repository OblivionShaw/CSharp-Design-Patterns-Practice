public class BuilderPatternMealBuilder
{
    public BuilderPatternMeal prepareVegMeal()
    {
        BuilderPatternMeal meal = new BuilderPatternMeal();
        meal.addItem(new BuilderPatternVegBurger());
        meal.addItem(new BuilderPatternCoke());
        return meal;
    }

    public BuilderPatternMeal prepareNonVegMeal()
    {
        BuilderPatternMeal meal = new BuilderPatternMeal();
        meal.addItem(new BuilderPatternChickenBurger());
        meal.addItem(new BuilderPatternPepsi());
        return meal;
    }
}

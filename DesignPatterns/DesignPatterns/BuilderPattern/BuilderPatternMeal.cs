public class BuilderPatternMeal
{
    private List<BuilderPatternItem> items = new List<BuilderPatternItem>();
    public List<BuilderPatternItem> Items{get { return items; }}

    public void addItem(BuilderPatternItem item)
    {
        items.Add(item);
    }

    public float getCost()
    {
        float cost = 0.0f;
        foreach (BuilderPatternItem item in items)
        {
            cost += item.price();
        }
        return cost;
    }

    public string showItems()
    {
        string result = "";
        foreach (BuilderPatternItem item in items)
        {
            result += "商品 : " + item.name() + ", 包裝方式 : " + item.packing().pack() + ", 價格 : " + item.price() + "\n";
        }
        return result;
    }
}

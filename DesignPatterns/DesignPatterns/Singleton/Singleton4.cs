//列舉式
public class Singleton4
{
    private static readonly Lazy<Singleton4> lazy = new Lazy<Singleton4>(() => new Singleton4());

    private Singleton4() { }

    public static Singleton4 Instance { get { return lazy.Value; } }

    public string ShowMessage()
    {
        return "Singleton4列舉式 is working";
    }
}
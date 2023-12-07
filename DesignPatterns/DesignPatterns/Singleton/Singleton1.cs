//餓式
public class Singleton1
{
    private static Singleton1 instance = new Singleton1();

    private Singleton1() { }

    public static Singleton1 GetInstance()
    {
        return instance;
    }

    public string ShowMessage()
    {
        return "Singleton1餓式 is working";
    }
}
//雙檢鎖/雙重校驗鎖（DCL，即 double-checked locking）
public class Singleton2
{
    private static volatile Singleton2 singleton = null;
    private static readonly object lockObject = new object();

    private Singleton2() { }

    public static Singleton2 GetSingleton()
    {
        if (singleton == null)
        {
            lock (lockObject)
            {
                if (singleton == null)
                {
                    singleton = new Singleton2();
                }
            }
        }
        return singleton;
    }

    public string ShowMessage()
    {
        return "Singleton2雙檢鎖 is working";
    }
}
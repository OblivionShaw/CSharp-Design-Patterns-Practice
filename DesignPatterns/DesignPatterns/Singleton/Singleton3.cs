//登記式/靜態內部類
public class Singleton3
{
    private class SingletonHolder
    {
        internal static readonly Singleton3 instance = new Singleton3();
        // 靜態構造函數，確保類被加載時就創建一個實例
        static SingletonHolder() { }
    }

    private Singleton3() { }

    public static Singleton3 GetInstance()
    {
        return SingletonHolder.instance;
    }

    public string ShowMessage()
    {
        return "Singleton3登記式 is working";
    }
}
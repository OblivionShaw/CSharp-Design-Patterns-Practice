public class AdapterPatternMp4Player : AdapterPatternAdvancedMediaPlayer
{

    public string PlayVlc(string fileName)
    {
        return "";
        //什么也不做
    }

    public string PlayMp4(string fileName)
    {
        return  "Playing mp4 file. Name: " + fileName ;
    }
}

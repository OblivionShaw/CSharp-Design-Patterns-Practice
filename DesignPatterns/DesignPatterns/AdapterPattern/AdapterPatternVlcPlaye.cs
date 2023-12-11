public class AdapterPatternVlcPlayer : AdapterPatternAdvancedMediaPlayer
{
    public string PlayVlc(string fileName)
    {
        return "Playing vlc file. Name: " + fileName;
    }

    public string PlayMp4(string fileName)
    {
        return "";
        //什么也不做
    }
}

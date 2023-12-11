public class AdapterPatternAudioPlayer : AdapterPatternMediaPlayer
{
    AdapterPatternMediaAdapter mediaAdapter;

    public string Play(string audioType, string fileName)
    {

        //播放 mp3 音乐文件的内置支持
        if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
        {
            return "Playing mp3 file. Name: " + fileName;
        }
        //mediaAdapter 提供了播放其他文件格式的支持
        else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase)
           || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            mediaAdapter = new AdapterPatternMediaAdapter(audioType);
            return mediaAdapter.Play(audioType, fileName);
        }
        else
        {
            return "Invalid media. " + audioType + " format not supported";
        }
    }
}
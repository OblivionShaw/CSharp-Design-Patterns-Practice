public class AdapterPatternMediaAdapter : AdapterPatternMediaPlayer
{

    AdapterPatternAdvancedMediaPlayer advancedMusicPlayer;

    public AdapterPatternMediaAdapter(string audioType)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer = new AdapterPatternVlcPlayer();
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer = new AdapterPatternMp4Player();
        }
    }

    public string Play(string audioType, string fileName)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            return advancedMusicPlayer.PlayVlc(fileName);
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            return advancedMusicPlayer.PlayMp4(fileName);
        }
        return null;
    }
}